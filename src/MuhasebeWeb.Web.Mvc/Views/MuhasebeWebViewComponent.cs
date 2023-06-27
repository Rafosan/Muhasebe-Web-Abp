using Abp.AspNetCore.Mvc.ViewComponents;

namespace MuhasebeWeb.Web.Views
{
    public abstract class MuhasebeWebViewComponent : AbpViewComponent
    {
        protected MuhasebeWebViewComponent()
        {
            LocalizationSourceName = MuhasebeWebConsts.LocalizationSourceName;
        }
    }
}
