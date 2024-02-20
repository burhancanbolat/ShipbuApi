namespace ShipbuApi.Models.Data;

public class TransportPaymentViewModel
{
    public Guid UserId { get; set; }
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }

}
