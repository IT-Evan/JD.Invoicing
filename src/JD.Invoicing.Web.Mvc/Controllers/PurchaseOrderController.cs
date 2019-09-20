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
    public class PurchaseOrderController : InvoicingControllerBase
    {
        private readonly IPurchaseOrderAppService _purchaseOrderAppService;
        const int MaxNum = 10;
        public PurchaseOrderController(IPurchaseOrderAppService purchaseOrderAppService)
        {
            _purchaseOrderAppService = purchaseOrderAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var purchaseOrderes = (await _purchaseOrderAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //PurchaseOrderDto cuPurchaseOrder = purchaseOrder.FirstOrDefault();
            var model = new PurchaseOrderListViewModel
            {
                //PurchaseOrder = cuPurchaseOrder,
                PurchaseOrders = purchaseOrderes
            };
            return View(model);
        }

        public async Task<ActionResult> EditPurchaseOrderModal(int purchaseOrderId)
        {
            var purchaseOrder = await _purchaseOrderAppService.Get(new EntityDto<int>(purchaseOrderId));
            //PurchaseOrderDto cuPurchaseOrder = AutoMapper.Mapper.Map<PurchaseOrderDto>(purchaseOrder);
            var model = new EditPurchaseOrderModalViewModel
            {
                PurchaseOrder = purchaseOrder
            };
            return View("_EditPurchaseOrderModal", model);
        }
    }
}