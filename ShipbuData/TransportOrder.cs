using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public class TransportOrder
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Name { get; set; }

    public User? User { get; set; }
    public ICollection<TransportOrderItem> TransportOrderItems { get; set; } = new HashSet<TransportOrderItem>();
}

public class TransportOrderEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrder>
{
    public void Configure(EntityTypeBuilder<TransportOrder> builder)
    {
        builder
            .HasMany(p => p.TransportOrderItems)
            .WithOne(p => p.TransportOrder)
            .HasForeignKey(p => p.TransportOrderId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}