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
        private readonly IPOAppService _poAppService;
        const int MaxNum = 10;
        public POController(IPOAppService poAppService)
        {
            _poAppService = poAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var pos = (await _poAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            var model = new POListViewModel
            {
                POs = pos
            };
            return View(model);
        }

        public async Task<ActionResult> EditPOModal(int poId)
        {
            var po = await _poAppService.Get(new EntityDto<int>(poId));
            //PurchaseOrderDto cuPurchaseOrder = AutoMapper.Mapper.Map<PurchaseOrderDto>(purchaseOrder);　
            var model = new EditPOModalViewModel
            {
                PO = po
            };
            return View("_EditPOModal", model);
        }
    }
}