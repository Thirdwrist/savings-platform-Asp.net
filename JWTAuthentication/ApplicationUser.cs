using System.Security.Claims;

namespace SavingsPlatformASP.net.JWTAuthentication
{
    public class ApplicationUser
    {
        public ApplicationUser()
        {
        }

        public ClaimsIdentity UserName { get; internal set; }
    }
}
