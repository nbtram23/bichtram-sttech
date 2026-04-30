using Abp.AspNetCore.Mvc.ViewComponents;

namespace bichtram.Web.Views
{
    public abstract class bichtramViewComponent : AbpViewComponent
    {
        protected bichtramViewComponent()
        {
            LocalizationSourceName = bichtramConsts.LocalizationSourceName;
        }
    }
}
