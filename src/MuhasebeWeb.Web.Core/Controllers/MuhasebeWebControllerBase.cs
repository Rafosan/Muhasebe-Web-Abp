using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MuhasebeWeb.Controllers
{
    public abstract class MuhasebeWebControllerBase: AbpController
    {
        protected MuhasebeWebControllerBase()
        {
            LocalizationSourceName = MuhasebeWebConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
