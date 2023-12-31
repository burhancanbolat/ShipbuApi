using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public class TransportOrderItemContainerType
{
    public Guid Id { get; set; }
    public bool Enabled { get; set; }
    public string NameTr { get; set; }
    public string NameEn { get; set; }
    public int DisplayOrder { get; set; }

    public ICollection<TransportOrderItemContainer> TransportOrderItemContainers { get; set; } = new HashSet<TransportOrderItemContainer>();
}

public class TransportOrderItemContainerTypeEntityTypeConfiguration  : IEntityTypeConfiguration<TransportOrderItemContainerType>
{
    public void Configure(EntityTypeBuilder<TransportOrderItemContainerType> builder)
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
            .HasMany(p => p.TransportOrderItemContainers)
            .WithOne(p => p.TransportOrderItemContainerType)
            .HasForeignKey(p => p.TransportOrderItemContainerTypeId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}


