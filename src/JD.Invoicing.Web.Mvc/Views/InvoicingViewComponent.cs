using Abp.AspNetCore.Mvc.ViewComponents;

namespace JD.Invoicing.Web.Views
{
    public abstract class InvoicingViewComponent : AbpViewComponent
    {
        protected InvoicingViewComponent()
        {
            LocalizationSourceName = InvoicingConsts.LocalizationSourceName;
        }
    }
}
