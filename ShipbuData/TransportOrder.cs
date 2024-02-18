using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public enum TransportOrderStatus
{
    Offer, Payment, Accepted, Shipped, Delivered, Cancelled
}

public class TransportOrder
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public string? Address { get; set; }
    public string? PhoneNumber { get; set; }
    public string? Name { get; set; }
    public decimal Price { get; set; }
    public Guid OriginId { get; set; }
    public Guid DestinationId { get; set; }
    public Guid TransportFeeId { get; set; }
    public TransportOrderStatus Status { get; set; }



    public string? ShippingNumber { get; set; }
    public string? TrackingNumber { get; set; }

    public User? User { get; set; }
    public ICollection<TransportOrderItem> TransportOrderItems { get; set; } = new HashSet<TransportOrderItem>();
    public TransportDistrict? District { get; set; }
    public TransportRegion? Origin { get; set; }
    public TransportFee? TransportFee { get; set; }
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