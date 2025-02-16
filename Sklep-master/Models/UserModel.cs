using Microsoft.AspNetCore.Identity;

namespace sklep.Models
{
    public class UserModel : IdentityUser
    {
        public string FullName { get; set; } 
        public DateTime DateOfBirth { get; set; } 
    }
}
