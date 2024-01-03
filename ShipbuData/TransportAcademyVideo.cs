using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ShipbuData;

public class TransportAcademyVideo
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }
    public string? DescriptionTr { get; set; }
    public string? DescriptionEn { get; set; }
    public string Url { get; set; }
    public string ImageUrl { get; set; }
    public int DisplayOrder { get; set; }
}


public class TransportAcademyVideoEntityTypeConfiguration : IEntityTypeConfiguration<TransportAcademyVideo>
{
    public void Configure(EntityTypeBuilder<TransportAcademyVideo> builder)
    {
        builder
            .HasIndex(p => new { p.NameTr })
            .IsUnique();

        builder
            .HasIndex(p => new { p.NameTr })
            .IsUnique();

        builder
            .Property(p => p.NameTr)
            .IsRequired();

        builder
            .Property(p => p.NameEn)
            .IsRequired();

        builder
            .Property(p => p.Url)
            .IsUnicode(false)
            .HasMaxLength(2048)
            .IsRequired();

        builder
            .Property(p => p.ImageUrl)
            .IsUnicode(false)
            .HasMaxLength(2048)
            .IsRequired();
    }
}


