using Microsoft.AspNetCore.Identity;

namespace eAppointmentServer.Domain.Entities
{
    public sealed class AppUser : IdentityUser<Guid>
    {
        public string FirsName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string FullName => string.Join(" ", FirsName, LastName);
    }
}
