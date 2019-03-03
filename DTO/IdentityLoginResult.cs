using System.Security.Claims;

namespace DTO
{
    public class IdentityLoginResult
    {
        public CustomerLoginResults CustomerLoginResults { get; set; }
        public ClaimsIdentity ClaimsIdentity { get; set; }
    }
}
