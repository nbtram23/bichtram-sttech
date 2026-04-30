using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace bichtram.Web.Views
{
    public abstract class bichtramRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected bichtramRazorPage()
        {
            LocalizationSourceName = bichtramConsts.LocalizationSourceName;
        }
    }
}
