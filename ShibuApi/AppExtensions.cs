using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ShipbuData;

namespace ShipbuApi;

public static class AppExtensions
{
    public static IApplicationBuilder UseShipbu(this IApplicationBuilder app)
    {
        using var scope = app.ApplicationServices.CreateAsyncScope();
        using var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        var configuration = scope.ServiceProvider.GetRequiredService<IConfiguration>();

        using var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<Role>>();
        using var userManager = scope.ServiceProvider.GetRequiredService<UserManager<User>>();

        context.Database.Migrate();

        new[]
        {
        new Role { Name ="Administrators"},
        new Role { Name ="Members"},
        }
        .ToList()
        .ForEach(p =>
        {
            if (!roleManager.RoleExistsAsync(p.Name!).Result)
                roleManager.CreateAsync(p).Wait();
        });

        {
            var defaultUser = userManager.FindByNameAsync(configuration.GetValue<string>("Security:DefaultUser:UserName")!).Result;
            if (defaultUser is null)
            {
                defaultUser = new User
                {
                    UserName = configuration.GetValue<string>("Security:DefaultUser:UserName")!,
                    Email = configuration.GetValue<string>("Security:DefaultUser:UserName")!,
                    Name = configuration.GetValue<string>("Security:DefaultUser:Name")!,
                    Enabled = true,
                    DateCreated = DateTime.UtcNow,
                    EmailConfirmed = true,
                };
                var createUserResult = userManager.CreateAsync(defaultUser, configuration.GetValue<string>("Security:DefaultUser:Password")!).Result;
                userManager.AddToRoleAsync(defaultUser, "Administrators").Wait();
            }
        }

        return app;
    }
}
