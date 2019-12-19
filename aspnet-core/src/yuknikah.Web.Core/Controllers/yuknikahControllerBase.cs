using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace yuknikah.Controllers
{
    public abstract class yuknikahControllerBase: AbpController
    {
        protected yuknikahControllerBase()
        {
            LocalizationSourceName = yuknikahConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
