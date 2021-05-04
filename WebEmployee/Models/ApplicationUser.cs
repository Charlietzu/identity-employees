using Microsoft.AspNetCore.Identity;

namespace WebEmployee.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string City { get; set; }
    }
}
