using Microsoft.AspNetCore.Identity;

namespace ProxyDP.API.Repositories
{
    public class AppUser : IdentityUser<Guid>
    {
        public MembershipType MembershipType { get; set; }
    }

    public enum MembershipType
    {
        Free,
        Premium,
        Enterprise
    }
}
