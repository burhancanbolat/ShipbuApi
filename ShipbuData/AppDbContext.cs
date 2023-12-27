using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ShipbuData;

public class AppDbContext : IdentityDbContext<User, Role, Guid>
{
    public AppDbContext(DbContextOptions options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(builder);
    }
    
    public DbSet<RefreshToken>  RefreshTokens { get; set; }

}
