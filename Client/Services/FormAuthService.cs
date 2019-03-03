using DTO;
using System;
using System.Web.Security;

namespace Client.Services
{
    public class FormAuthService : IAuthService
    {
        public CustomerLoginResults SignIn(string username, string password, bool isPersistent, bool shouldLockOut)
        {
            // Your SignIn implementation here...
            throw new NotImplementedException();
        }

        public void SignOut()
        {
            // Your SignIn implementation here...
            FormsAuthentication.SignOut();            
        }
    }
}