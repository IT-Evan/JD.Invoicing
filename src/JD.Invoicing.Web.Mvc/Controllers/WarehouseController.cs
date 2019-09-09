using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Authorization;
using JD.Invoicing.Controllers;
using JD.Invoicing.Warehouse;
using JD.Invoicing.Warehouse.Dto;
using JD.Invoicing.Web.Models.Warehouse;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;


namespace JD.Invoicing.Web.Controllers
{

    [AbpMvcAuthorize(PermissionNames.Pages_Warehouse)]
    public class WarehouseController : InvoicingControllerBase
    {
        const int MaxNum = 10;
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            var module = (await _WarehouseAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            WarehouseDto cuModule = module.FirstOrDefault();
            var model = new WarehouseListViewModel
            {

                Warehouse = cuModule,
                Warehouses = module

            };
            return View(model);
        }

        private readonly IWarehouseAppService _WarehouseAppService;

        public WarehouseController(IWarehouseAppService WarehouseAppService)
        {
            _WarehouseAppService = WarehouseAppService;

        }
        public async Task<ActionResult> EditWarehouseModal(int moduleId)

        {
            var module = await _WarehouseAppService.Get(new EntityDto<int>(moduleId));
            CreateUpdateWarehouseDto cuWarehouse = AutoMapper.Mapper.Map<CreateUpdateWarehouseDto>(module);
            var model = new EditWarehouseModalViewModel
            {
                Warehouse = cuWarehouse

            };
            return View("_EditWarehouseModal", model);
        }
    }
}