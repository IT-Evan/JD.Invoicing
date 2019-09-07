using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Controllers;

namespace JD.Invoicing.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : InvoicingControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
