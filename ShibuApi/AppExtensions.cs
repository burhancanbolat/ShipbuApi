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



                var GokceKose = userManager.FindByNameAsync(configuration.GetValue<string>("Security:GokceKose:UserName")!).Result;
                if (GokceKose is null)
                {
                    GokceKose = new User
                    {
                        UserName = configuration.GetValue<string>("Security:GokceKose:UserName")!,
                        Email = configuration.GetValue<string>("Security:GokceKose:UserName")!,
                        Name = configuration.GetValue<string>("Security:GokceKose:Name")!,
                        Enabled = true,
                        DateCreated = DateTime.UtcNow,
                        EmailConfirmed = true,
                    };
                    var GokceKoseResult = userManager.CreateAsync(GokceKose, configuration.GetValue<string>("Security:GokceKose:Password")!).Result;
                    userManager.AddToRoleAsync(GokceKose, "Administrators").Wait();
                }



                 var TugerAkkaya = userManager.FindByNameAsync(configuration.GetValue<string>("Security:TugerAkkaya:UserName")!).Result;
                if (TugerAkkaya is null)
                {
                    TugerAkkaya = new User
                    {
                        UserName = configuration.GetValue<string>("Security:TugerAkkaya:UserName")!,
                        Email = configuration.GetValue<string>("Security:TugerAkkaya:UserName")!,
                        Name = configuration.GetValue<string>("Security:TugerAkkaya:Name")!,
                        Enabled = true,
                        DateCreated = DateTime.UtcNow,
                        EmailConfirmed = true,
                    };
                    var TugerAkkayaResult = userManager.CreateAsync(TugerAkkaya, configuration.GetValue<string>("Security:TugerAkkaya:Password")!).Result;
                    userManager.AddToRoleAsync(TugerAkkaya, "Administrators").Wait();
                }




                var YaseminBetni = userManager.FindByNameAsync(configuration.GetValue<string>("Security:YaseminBetni:UserName")!).Result;
                if (YaseminBetni is null)
                {
                    YaseminBetni = new User
                    {
                        UserName = configuration.GetValue<string>("Security:YaseminBetni:UserName")!,
                        Email = configuration.GetValue<string>("Security:YaseminBetni:UserName")!,
                        Name = configuration.GetValue<string>("Security:YaseminBetni:Name")!,
                        Enabled = true,
                        DateCreated = DateTime.UtcNow,
                        EmailConfirmed = true,
                    };
                    var YaseminBetniResult = userManager.CreateAsync(YaseminBetni, configuration.GetValue<string>("Security:YaseminBetni:Password")!).Result;
                    userManager.AddToRoleAsync(YaseminBetni, "Administrators").Wait();
                }


                var EbruOnay = userManager.FindByNameAsync(configuration.GetValue<string>("Security:EbruOnay:UserName")!).Result;
                if (EbruOnay is null)
                {
                    EbruOnay = new User
                    {
                        UserName = configuration.GetValue<string>("Security:EbruOnay:UserName")!,
                        Email = configuration.GetValue<string>("Security:EbruOnay:UserName")!,
                        Name = configuration.GetValue<string>("Security:EbruOnay:Name")!,
                        Enabled = true,
                        DateCreated = DateTime.UtcNow,
                        EmailConfirmed = true,
                    };
                    var EbruOnayResult = userManager.CreateAsync(EbruOnay, configuration.GetValue<string>("Security:EbruOnay:Password")!).Result;
                    userManager.AddToRoleAsync(EbruOnay, "Administrators").Wait();
                }
            }

            return app;
        }
    }
}
