using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public abstract class TransportOrderItem
{
    public Guid Id { get; set; }
    public Guid TransportOrderId { get; set; }
    public bool HasAddress { get; set; }
    public string? Address { get; set; }
    public string PhoneNumber { get; set; }
    public string Name { get; set; }
    public TransportOrder? TransportOrder { get; set; }
    public ICollection<TransportOrderItemFeatureValue> TransportOrderItemFeatureValues { get; set; } = new HashSet<TransportOrderItemFeatureValue>();
    public ICollection<TransportOrderItemFeature> TransportOrderItemFeatures { get; set; } = new HashSet<TransportOrderItemFeature>();
}

public class TransportOrderItemPackage : TransportOrderItem
{
    public int Quantity { get; set; }
    public float Weight { get; set; }
    public float Width { get; set; }
    public float Length { get; set; }
    public float Height { get; set; }
    public string? Content { get; set; }
    public int Products { get; set; }
    public string Image { get; set; }
}

public class TransportOrderItemPallet : TransportOrderItem
{
    public int Quantity { get; set; }
    public float Weight { get; set; }
    public float Width { get; set; }
    public float Length { get; set; }
    public float Height { get; set; }
    public string? Content { get; set; }


}

public class TransportOrderItemContainer : TransportOrderItem
{
    public int Quantity { get; set; }
    public float Weight { get; set; }
    public Guid TransportOrderItemContainerTypeId { get; set; }

    public TransportOrderItemContainerType? TransportOrderItemContainerType { get; set; }
}

public abstract class TransportOrderItemEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItem>
{
    public void Configure(EntityTypeBuilder<TransportOrderItem> builder)
    {
        builder
            .HasMany(p => p.TransportOrderItemFeatures)
            .WithMany(p => p.TransportOrderItems)
            .UsingEntity<TransportOrderItemFeatureValue>(
            l => l.HasOne<TransportOrderItemFeature>().WithMany().HasForeignKey(p => p.TransportOrderItemFeature),
            r => r.HasOne<TransportOrderItem>().WithMany().HasForeignKey(p => p.TransportOrderItem)
            );

    }
}