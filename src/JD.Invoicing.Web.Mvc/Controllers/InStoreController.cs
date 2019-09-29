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
    [AbpMvcAuthorize(PermissionNames.Pages_InStore)]
    public class InStoreController : InvoicingControllerBase
    {
        private readonly IStoreAppService _storeAppService;
        const int MaxNum = 10;
        public InStoreController(IStoreAppService storeAppService)
        {
            _storeAppService = storeAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var _stores = (await _storeAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            var model = new StoreListViewModel
            {
                Stores = _stores
            };
            return View(model);
        }

        public async Task<ActionResult> EditStoreModal(int storeId)
        {
            var store = await _storeAppService.Get(new EntityDto<int>(storeId));
            var model = new EditStoreModalViewModel
            {
                Store = store
            };
            return View("_EditStoreModal", model);
        }
    }
}