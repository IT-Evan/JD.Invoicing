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
    public class InStoreDetialController : InvoicingControllerBase
    {
        private readonly IStoreDetialAppService _storeDetialAppService;
        const int MaxNum = 10;
        public InStoreDetialController(IStoreDetialAppService storeDetialAppService)
        {
            _storeDetialAppService = storeDetialAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var storeDetials = (await _storeDetialAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //StoreDetialDto cuStoreDetial = storeDetial.FirstOrDefault();
            var model = new StoreDetialListViewModel
            {
                //StoreDetial = cuStoreDetial,
                StoreDetials = storeDetials
            };
            return View(model);
        }

        public async Task<ActionResult> EditStoreDetialModal(int storeDetialId)
        {
            var storeDetial = await _storeDetialAppService.Get(new EntityDto<int>(storeDetialId));
            //StoreDetialDto cuStoreDetial = AutoMapper.Mapper.Map<StoreDetialDto>(storeDetial);
            var model = new EditStoreDetialModalViewModel
            {
                StoreDetial = storeDetial
            };
            return View("_EditStoreDetialModal", model);
        }
    }
}