using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public abstract class TransportOrderItem
{
    public Guid Id { get; set; }
    public Guid TransportOrderId { get; set; }
    public string Image { get; set; }
    public int Quantity { get; set; }
    public float Weight { get; set; }
    public TransportOrder? TransportOrder { get; set; }

    //public ICollection<TransportOrderItemFeatureValue> TransportOrderItemFeatureValues { get; set; } = new HashSet<TransportOrderItemFeatureValue>();
    public ICollection<TransportOrderItemFeature> TransportOrderItemFeatures { get; set; } = new HashSet<TransportOrderItemFeature>();
}


public class TransportOrderItemEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItem>
{
    public void Configure(EntityTypeBuilder<TransportOrderItem> builder)
    {
        //builder
        //    .HasMany(p => p.TransportOrderItemFeatures)
        //    .WithMany(p => p.TransportOrderItems)
        //    .UsingEntity<TransportOrderItemFeatureValue>(
        //    l => l.HasOne<TransportOrderItemFeature>().WithMany().HasForeignKey(p => p.TransportOrderItemFeature),
        //    r => r.HasOne<TransportOrderItem>().WithMany().HasForeignKey(p => p.TransportOrderItem)
        //    );
    }
}


public class TransportOrderItemPackage : TransportOrderItem
{
    public float Width { get; set; }
    public float Length { get; set; }
    public float Height { get; set; }
    public string? Content { get; set; }
    public int Products { get; set; }
}


public class TransportOrderItemPackageEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItemPackage>
{
    public void Configure(EntityTypeBuilder<TransportOrderItemPackage> builder)
    {
        builder
            .ToTable("TransportOrderItemPackages");
    }
}

public class TransportOrderItemPallet : TransportOrderItem
{
    
    public float Width { get; set; }
    public float Length { get; set; }
    public float Height { get; set; }
    public string? Content { get; set; }

}
public class TransportOrderItemPalletEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItemPallet>
{
    public void Configure(EntityTypeBuilder<TransportOrderItemPallet> builder)
    {
        builder
            .ToTable("TransportOrderItemPallets");
    }
}

public class TransportOrderItemContainer : TransportOrderItem
{
    public Guid TransportOrderItemContainerTypeId { get; set; }

    public TransportOrderItemContainerType? TransportOrderItemContainerType { get; set; }
}
public class TransportOrderItemContainerEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItemContainer>
{
    public void Configure(EntityTypeBuilder<TransportOrderItemContainer> builder)
    {
        builder
            .ToTable("TransportOrderItemContainers");
    }
}
