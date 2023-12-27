using Microsoft.AspNetCore.Identity;

namespace ShipbuData;

public class User : IdentityUser<Guid>
{
    public string Name { get; set; }
    public DateTime DateCreated { get; set; }
    public bool Enabled { get; set; }
}
