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
        private readonly IWarehouseAppService _warehouseAppService;
        const int MaxNum = 10;
        public WarehouseController(IWarehouseAppService warehouseAppService)
        {
            _warehouseAppService = warehouseAppService;

        }
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            var warehouses = (await _warehouseAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            //WarehouseDto cuModule = warehouses.FirstOrDefault();
            var model = new WarehouseListViewModel
            {
                //Warehouse = cuModule,
                Warehouses = warehouses
            };
            return View(model);
        }

        public async Task<ActionResult> EditWarehouseModal(int warehouseId)

        {
            var warehouse = await _warehouseAppService.Get(new EntityDto<int>(warehouseId));
            //CreateUpdateWarehouseDto cuWarehouse = AutoMapper.Mapper.Map<CreateUpdateWarehouseDto>(module);
            var model = new EditWarehouseModalViewModel
            {
                Warehouse = warehouse

            };
            return View("_EditWarehouseModal", model);
        }
    }
}