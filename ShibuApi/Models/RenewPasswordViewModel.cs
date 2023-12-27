namespace ShipbuApi.Models
{
    public class RenewPasswordViewModel
    {
        public required string Token { get; set; }
        public required string UserName { get; set; }
        public required string Password { get; set; }

    }
}
