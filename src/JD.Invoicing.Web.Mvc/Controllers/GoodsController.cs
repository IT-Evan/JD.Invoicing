using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Authorization;
using JD.Invoicing.Controllers;
using JD.Invoicing.Goods;
using JD.Invoicing.Goods.Dto;
using JD.Invoicing.Web.Models.Goods;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace JD.Invoicing.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Goods)]
    public class GoodsController : InvoicingControllerBase
    {
        private readonly IGoodsAppService _goodsAppService;
        const int MaxNum = 10;
        public GoodsController(IGoodsAppService goodsAppService)
        {
            _goodsAppService = goodsAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var _goodses = (await _goodsAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            //Paging not implemented yet
            //GoodsDto cuGoods = goods.FirstOrDefault();
            var model = new GoodsListViewModel
            {
                //Goods = cuGoods,
                Goodses = _goodses
            };
            return View(model);
        }

        public async Task<ActionResult> EditGoodsModal(int goodsId)
        {
            var goods = await _goodsAppService.Get(new EntityDto<int>(goodsId));
            //GoodsDto cuGoods = AutoMapper.Mapper.Map<GoodsDto>(goods);
            var model = new EditGoodsModalViewModel
            {
                Goods = goods
            };
            return View("_EditGoodsModal", model);
        }
    }
}