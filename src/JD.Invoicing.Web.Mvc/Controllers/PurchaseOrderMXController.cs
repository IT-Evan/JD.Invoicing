using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Authorization;
using JD.Invoicing.Controllers;
using JD.Invoicing.Purchase;
using JD.Invoicing.Purchase.Dto;
using JD.Invoicing.Web.Models.Purchase;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace JD.Invoicing.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_PurchaseOrder)]
    public class PurchaseOrderMXController : InvoicingControllerBase
    {
        private readonly IPurchaseOrderMXAppService _purchaseOrderMXAppService;
        const int MaxNum = 10;
        public PurchaseOrderMXController(IPurchaseOrderMXAppService purchaseOrderMXAppService)
        {
            _purchaseOrderMXAppService = purchaseOrderMXAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var purchaseOrderMXes = (await _purchaseOrderMXAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //PurchaseOrderMXDto cuPurchaseOrderMX = purchaseOrderMX.FirstOrDefault();
            var model = new PurchaseOrderMXListViewModel
            {
                //PurchaseOrderMX = cuPurchaseOrderMX,
                PurchaseOrderMXs = purchaseOrderMXes
            };
            return View(model);
        }

        public async Task<ActionResult> EditPurchaseOrderMXModal(int purchaseOrderMXId)
        {
            var purchaseOrderMX = await _purchaseOrderMXAppService.Get(new EntityDto<int>(purchaseOrderMXId));
            //PurchaseOrderMXDto cuPurchaseOrderMX = AutoMapper.Mapper.Map<PurchaseOrderMXDto>(purchaseOrderMX);
            var model = new EditPurchaseOrderMXModalViewModel
            {
                PurchaseOrderMX = purchaseOrderMX
            };
            return View("_EditPurchaseOrderMXModal", model);
        }
    }
}