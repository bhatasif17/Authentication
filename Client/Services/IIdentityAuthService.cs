using DTO;
using System.Security.Claims;

namespace Client.Services
{
    public interface IIdentityAuthService : IAuthService
    {
        bool IdentityUserExistsById(string userId);
        bool SupportsUserSecurityStamp();
        string GetSecurityStamp(string userId);
        ClaimsIdentity CreateIdentity(string userId);
        bool Create(Account account, string password);        
    }
}