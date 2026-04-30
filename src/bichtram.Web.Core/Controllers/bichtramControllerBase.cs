using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace bichtram.Controllers
{
    public abstract class bichtramControllerBase: AbpController
    {
        protected bichtramControllerBase()
        {
            LocalizationSourceName = bichtramConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
