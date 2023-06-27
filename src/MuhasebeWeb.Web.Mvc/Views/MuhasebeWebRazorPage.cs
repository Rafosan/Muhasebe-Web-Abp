using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace MuhasebeWeb.Web.Views
{
    public abstract class MuhasebeWebRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MuhasebeWebRazorPage()
        {
            LocalizationSourceName = MuhasebeWebConsts.LocalizationSourceName;
        }
    }
}
