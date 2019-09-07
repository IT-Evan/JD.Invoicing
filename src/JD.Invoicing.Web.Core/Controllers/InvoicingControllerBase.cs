using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace JD.Invoicing.Controllers
{
    public abstract class InvoicingControllerBase: AbpController
    {
        protected InvoicingControllerBase()
        {
            LocalizationSourceName = InvoicingConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
