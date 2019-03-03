using DTO;

namespace Client.Services
{
    public interface IAuthService
    {
        CustomerLoginResults SignIn(string username, string password, bool isPersistent, bool shouldLockOut);
        void SignOut();
    }
}
