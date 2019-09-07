using Microsoft.AspNetCore.Antiforgery;
using JD.Invoicing.Controllers;

namespace JD.Invoicing.Web.Host.Controllers
{
    public class AntiForgeryController : InvoicingControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
