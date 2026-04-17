using Microsoft.AspNetCore.Identity;

namespace SchoolManagementSystem.Models
{
    public class ApplicationUser :IdentityUser
    {
        public String? FullName { get; set; }=string.Empty;
    }
}
