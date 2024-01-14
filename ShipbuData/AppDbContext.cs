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

    public DbSet<TransportOrder> TransportOrders { get; set; }
    public DbSet<TransportOrderItem> TransportOrderItems { get; set; }
    public DbSet<TransportOrderItemContainerType> TransportOrderItemContainerTypes { get; set; }
    public DbSet<TransportOrderItemFeature> TransportOrderItemFeatures { get; set; }
    public DbSet<TransportStaticPage> TransportStaticPages { get; set; }
    public DbSet<TransportAcademyVideo> TransportAcademyVideos { get; set; }
    public DbSet<TransportRegion> TransportRegions { get; set; }
    public DbSet<TransportDistrict> TransportDistricts { get; set; }
    public DbSet<TransportMethod> TransportMethods { get; set; }
    public DbSet<TransportFee> TransportFees { get; set; }

}
