using Microsoft.AspNet.Identity.EntityFramework;
using Service.Data;

namespace Service.Services.Authentication
{
    public class ApplicationUserStore : UserStore<IdentityUser>
    {
        public ApplicationUserStore(AppDbContext appDbContext)
            : base(appDbContext)
        {

        }
    }
}