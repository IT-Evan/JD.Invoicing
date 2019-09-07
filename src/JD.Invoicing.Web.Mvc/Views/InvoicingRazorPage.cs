using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace JD.Invoicing.Web.Views
{
    public abstract class InvoicingRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected InvoicingRazorPage()
        {
            LocalizationSourceName = InvoicingConsts.LocalizationSourceName;
        }
    }
}
