using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;
using ShipbuApi;
using ShipbuData;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext>(config =>
{
    var provider = builder.Configuration.GetValue<string>("DbProvider")!;

    switch (provider)
    {
        case "MySQL":
            config.UseMySql(
                builder.Configuration.GetConnectionString(provider),
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString(provider)), x => x.MigrationsAssembly("MigrationsMySQL"));
            break;
        case "SqlServer":
        default:
            config.UseSqlServer(builder.Configuration.GetConnectionString(provider), x => x.MigrationsAssembly("MigrationsSqlServer"));
            break;
    }
});

builder.Services.AddIdentity<User, Role>(options =>
{
    options.SignIn.RequireConfirmedEmail = true;

    options.User.RequireUniqueEmail = false;

    options.Password.RequireDigit = builder.Configuration.GetValue<bool>("Security:Password:RequireDigit");
    options.Password.RequiredLength = builder.Configuration.GetValue<int>("Security:Password:RequiredLength");
    options.Password.RequireLowercase = builder.Configuration.GetValue<bool>("Security:Password:RequireLowercase");
    options.Password.RequireUppercase = builder.Configuration.GetValue<bool>("Security:Password:RequireUppercase");
    options.Password.RequireNonAlphanumeric = builder.Configuration.GetValue<bool>("Security:Password:RequireNonAlphanumeric");
    options.Password.RequiredUniqueChars = builder.Configuration.GetValue<int>("Security:Password:RequiredUniqueChars");

    options.Lockout.MaxFailedAccessAttempts = builder.Configuration.GetValue<int>("Security:Lockout:MaxFailedAccessAttempts");
    options.Lockout.DefaultLockoutTimeSpan = builder.Configuration.GetValue<TimeSpan>("Security:Lockout:DefaultLockoutTimeSpan");

    options.Tokens.EmailConfirmationTokenProvider = TokenOptions.DefaultEmailProvider;
    options.Tokens.PasswordResetTokenProvider = TokenOptions.DefaultEmailProvider;

})
    .AddErrorDescriber<AppIdentityErrorDescriber>()
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


builder.Services

    .AddAuthentication(options =>
    {
        options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
    })
    .AddJwtBearer(config =>
    {
        config.RequireHttpsMetadata = false;
        config.SaveToken = true;
        config.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(builder.Configuration.GetValue<string>("Security:Secret")!)),
            ValidateIssuer = false,
            ValidateAudience = false,
            //ValidAudience = "wwww.asdf.com"
            ClockSkew = builder.Configuration.GetValue<TimeSpan>("Security:ClockSkew")
        };

    });

builder.Services.AddMailKit(optionBuilder =>
{
    optionBuilder.UseMailKit(new MailKitOptions()
    {
        Server = builder.Configuration.GetValue<string>("EMail:Server"),
        Port = builder.Configuration.GetValue<int>("EMail:Port"),
        SenderName = builder.Configuration.GetValue<string>("EMail:SenderName"),
        SenderEmail = builder.Configuration.GetValue<string>("EMail:SenderEmail"),
        Account = builder.Configuration.GetValue<string>("EMail:Account"),
        Password = builder.Configuration.GetValue<string>("EMail:Password"),
        Security = builder.Configuration.GetValue<bool>("EMail:SslEnabled")
    });
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(config =>
{
    var jwtSecurityScheme = new OpenApiSecurityScheme
    {
        Scheme = "bearer",
        BearerFormat = "JWT",
        Name = "JWT Authentication",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Description = "Bearer token....",

        Reference = new OpenApiReference
        {
            Id = JwtBearerDefaults.AuthenticationScheme,
            Type = ReferenceType.SecurityScheme
        }
    };

    config.AddSecurityDefinition(jwtSecurityScheme.Reference.Id, jwtSecurityScheme);

    config.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        { jwtSecurityScheme, Array.Empty<string>() }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseCors(config=> config.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.UseShipbu();

app.Run();
