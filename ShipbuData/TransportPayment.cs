using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ShipbuData;

public class TransportPayment
{
    public Guid Id { get; set; }
    public DateTime Date { get; set; }
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
    public User? User { get; set; }
}
public class TransportPaymentEntityTypeConfiguration : IEntityTypeConfiguration<TransportPayment>
{
    public void Configure(EntityTypeBuilder<TransportPayment> builder)
    {

    }
}