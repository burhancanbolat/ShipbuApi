using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public class TransportOrderItemFeatureValue
{
    public Guid TransportOrderItemId { get; set; }
    public Guid TransportOrderItemFeatureId { get; set; }
    public string? Attachment { get; set; }

    public TransportOrderItemFeature?  TransportOrderItemFeature { get; set; }
    public TransportOrderItem? TransportOrderItem { get; set; }
}

public class TransportOrderItemFeatureValueEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItemFeatureValue>
{
    public void Configure(EntityTypeBuilder<TransportOrderItemFeatureValue> builder)
    {
        builder
            .HasKey(p => new { p.TransportOrderItemFeatureId, p.TransportOrderItemId });
    }
}