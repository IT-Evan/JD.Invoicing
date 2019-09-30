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
    public class PODetialController : InvoicingControllerBase
    {
        private readonly IPODetialAppService _PODetialAppService;
        const int MaxNum = 10;
        public PODetialController(IPODetialAppService PODetialAppService)
        {
            _PODetialAppService = PODetialAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var PODetials = (await _PODetialAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //PODetialDto cuPODetial = PODetial.FirstOrDefault();　
            var model = new PODetialListViewModel
            {
                //PODetial = cuPODetial,　
                PODetials = PODetials
            };
            return View(model);
        }

        public async Task<ActionResult> EditPODetialModal(int PODetialId)
        {
            var PODetial = await _PODetialAppService.Get(new EntityDto<int>(PODetialId));
            //PODetialDto cuPODetial = AutoMapper.Mapper.Map<PODetialDto>(PODetial);
            var model = new EditPODetialModalViewModel
            {
                PODetial = PODetial
            };
            return View("_EditPODetialModal", model);
        }
    }
}