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
    [AbpMvcAuthorize(PermissionNames.Pages_PurchaseWarehousing)]
    public class PurchaseWarehousingController : InvoicingControllerBase
    {
        private readonly IPurchaseWarehousingAppService _purchaseWarehousingAppService;
        const int MaxNum = 10;
        public PurchaseWarehousingController(IPurchaseWarehousingAppService purchaseWarehousingAppService)
        {
            _purchaseWarehousingAppService = purchaseWarehousingAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var purchaseWarehousinges = (await _purchaseWarehousingAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //PurchaseWarehousingDto cuPurchaseWarehousing = purchaseWarehousing.FirstOrDefault();
            var model = new PurchaseWarehousingListViewModel
            {
                //PurchaseWarehousing = cuPurchaseWarehousing,
                PurchaseWarehousings = purchaseWarehousinges
            };
            return View(model);
        }

        public async Task<ActionResult> EditPurchaseWarehousingModal(int purchaseWarehousingId)
        {
            var purchaseWarehousing = await _purchaseWarehousingAppService.Get(new EntityDto<int>(purchaseWarehousingId));
            //PurchaseWarehousingDto cuPurchaseWarehousing = AutoMapper.Mapper.Map<PurchaseWarehousingDto>(purchaseWarehousing);
            var model = new EditPurchaseWarehousingModalViewModel
            {
                PurchaseWarehousing = purchaseWarehousing
            };
            return View("_EditPurchaseWarehousingModal", model);
        }
    }
}