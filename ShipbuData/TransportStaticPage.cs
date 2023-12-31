using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public class TransportStaticPage
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public string LabelTr { get; set; }
    public string ContentTr { get; set; }
    public string LabelEn { get; set; }
    public string ContentEn { get; set; }
    public int DisplayOrder { get; set; }
    public int Views { get; set; }
}

public class TransportStaticPageEntityTypeConfiguration : IEntityTypeConfiguration<TransportStaticPage>
{
    public void Configure(EntityTypeBuilder<TransportStaticPage> builder)
    {
        builder
            .Property(p => p.LabelTr)
            .IsRequired();

        builder
            .Property(p => p.LabelEn)
            .IsRequired();

        builder
            .Property(p => p.ContentTr)
            .IsRequired();

        builder
            .Property(p => p.ContentEn)
            .IsRequired();

    }
}