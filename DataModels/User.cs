using Microsoft.AspNetCore.Identity;

namespace RealWorldBackend.DataModels
{
    public class ApplicationUser : IdentityUser
    {
        public string? Bio { get; set; }

        public string? Image { get; set; }
    }
}
