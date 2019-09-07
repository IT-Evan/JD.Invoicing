using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Controllers;
using JD.Invoicing.Goods;
using JD.Invoicing.Goods.Dto;
using JD.Invoicing.Web.Models.Goods;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace JD.Invoicing.Web.Controllers
{
    [AbpMvcAuthorize]
    public class GoodsController : InvoicingControllerBase
    {
        const int MaxNum = 10;
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            var module = (await _goodsAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            GoodsDto cuModule = module.FirstOrDefault();
            var model = new GoodsListViewModel
            {

                Goods = cuModule,
                Goodses = module

            };
            return View(model);
        }

        private readonly IGoodsAppService _goodsAppService;

        public GoodsController(IGoodsAppService goodsAppService)
        {
            _goodsAppService = goodsAppService;

        }
        public async Task<ActionResult> EditGoodsModal(int moduleId)

        {
            var module = await _goodsAppService.Get(new EntityDto<int>(moduleId));
            GoodsDto cuGoods = AutoMapper.Mapper.Map<GoodsDto>(module);
            var model = new EditGoodsModalViewModel
            {
                Goods = cuGoods

            };
            return View("_EditGoodsModal", model);
        }
    }
}