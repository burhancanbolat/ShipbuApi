using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ShipbuData;

public class RefreshToken
{
    public Guid UserId { get; set; }
    public Guid Token { get; set; }
}

public class RefreshTokenEntityTypeConfiguration : IEntityTypeConfiguration<RefreshToken>
{
    public void Configure(EntityTypeBuilder<RefreshToken> builder)
    {
        builder
            .HasKey(p => new { p.UserId, p.Token });
    }
}
