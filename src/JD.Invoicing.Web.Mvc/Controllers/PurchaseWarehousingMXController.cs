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
    [AbpMvcAuthorize(PermissionNames.Pages_Purchase)]
    public class PurchaseWarehousingMXController : InvoicingControllerBase
    {
        private readonly IPurchaseWarehousingMXAppService _purchaseWarehousingMXAppService;
        const int MaxNum = 10;
        public PurchaseWarehousingMXController(IPurchaseWarehousingMXAppService purchaseWarehousingMXAppService)
        {
            _purchaseWarehousingMXAppService = purchaseWarehousingMXAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var purchaseWarehousingMXes = (await _purchaseWarehousingMXAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //PurchaseWarehousingMXDto cuPurchaseWarehousingMX = purchaseWarehousingMX.FirstOrDefault();
            var model = new PurchaseWarehousingMXListViewModel
            {
                //PurchaseWarehousingMX = cuPurchaseWarehousingMX,
                PurchaseWarehousingMXs = purchaseWarehousingMXes
            };
            return View(model);
        }

        public async Task<ActionResult> EditPurchaseWarehousingMXModal(int purchaseWarehousingMXId)
        {
            var purchaseWarehousingMX = await _purchaseWarehousingMXAppService.Get(new EntityDto<int>(purchaseWarehousingMXId));
            //PurchaseWarehousingMXDto cuPurchaseWarehousingMX = AutoMapper.Mapper.Map<PurchaseWarehousingMXDto>(purchaseWarehousingMX);
            var model = new EditPurchaseWarehousingMXModalViewModel
            {
                PurchaseWarehousingMX = purchaseWarehousingMX
            };
            return View("_EditPurchaseWarehousingMXModal", model);
        }
    }
}