namespace ShipbuApi.Models
{
    public class ResetPasswordViewModel
    {
        public string Token { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }
}
