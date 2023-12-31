using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public class User : IdentityUser<Guid>
{
    public string Name { get; set; }
    public DateTime DateCreated { get; set; }
    public bool Enabled { get; set; }
    public Guid? RefreshToken { get; set; }

    public ICollection<TransportOrder> TransportOrders { get; set; } = new HashSet<TransportOrder>();

}

public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .Property(p => p.Name)
            .IsRequired();

        builder
            .HasMany(p => p.TransportOrders)
            .WithOne(p => p.User)
            .HasForeignKey(p => p.UserId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
