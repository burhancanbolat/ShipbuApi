using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public enum FeatureAttachmentType
{
    None, Image, PortableDocumentFile, Text
}

public class TransportOrderItemFeature
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public FeatureAttachmentType Type { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }
    public string DescriptionTr { get; set; }
    public string DescriptionEn { get; set; }
    public int DisplayOrder { get; set; }
    public string? AttachmentDescriptionTr { get; set; }
    public string? AttachmentDescriptionEn { get; set; }
    public decimal Fee { get; set; } = 0;

    public ICollection<TransportOrderItemFeatureValue> TransportOrderItemFeatureValues { get; set; } = new HashSet<TransportOrderItemFeatureValue>();
    public ICollection<TransportOrderItem> TransportOrderItems { get; set; } = new HashSet<TransportOrderItem>();
}

public class TransportOrderItemFeatureEntityTypeConfiguration : IEntityTypeConfiguration<TransportOrderItemFeature>
{
    public void Configure(EntityTypeBuilder<TransportOrderItemFeature> builder)
    {
        builder
            .HasIndex(p => new { p.NameTr })
            .IsUnique();
        builder
            .HasIndex(p => new { p.NameEn })
            .IsUnique();

        builder
            .Property(p => p.NameTr)
            .IsRequired();

        builder
            .Property(p => p.NameEn)
            .IsRequired();

    }
}
