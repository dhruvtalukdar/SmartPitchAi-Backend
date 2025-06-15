using Microsoft.AspNet.Identity.EntityFramework;

namespace SmartPitchAi.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        // id, userName, Email, PhoneNumber, PasswordHash coming from Identity user
        public string? FullName { get; set; }
    }
}
