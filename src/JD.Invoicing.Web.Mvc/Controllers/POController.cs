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
    [AbpMvcAuthorize(PermissionNames.Pages_PO)]
    public class POController : InvoicingControllerBase
    {
        private readonly IPOAppService _POAppService;
        const int MaxNum = 10;
        public POController(IPOAppService POAppService)
        {
            _POAppService = POAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var POs = (await _POAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            var model = new POListViewModel
            {
                POs = POs
            };
            return View(model);
        }

        public async Task<ActionResult> EditPOModal(int POId)
        {
            var PO = await _POAppService.Get(new EntityDto<int>(POId));
            //PurchaseOrderDto cuPurchaseOrder = AutoMapper.Mapper.Map<PurchaseOrderDto>(purchaseOrder);
            var model = new EditPOModalViewModel
            {
                PO = PO
            };
            return View("_EditPOModal", model);
        }
    }
}