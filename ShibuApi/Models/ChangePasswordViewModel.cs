﻿namespace ShipbuApi.Models
{
    public class ChangePasswordViewModel
    {
        public required string CurrentPassword { get; set; }
        public required string NewPassword { get; set; }
    }
}
