using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Controllers;
using JD.Invoicing.Customer;
using JD.Invoicing.Customer.Dto;
using JD.Invoicing.Web.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;


namespace JD.Invoicing.Web.Controllers
{

    [AbpMvcAuthorize]
    public class CustomerController : InvoicingControllerBase
    {
        const int MaxNum = 10;
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {

            var module = (await _CustomerAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            CustomerDto cuModule = module.FirstOrDefault();
            var model = new CustomerListViewModel
            {

                Customer = cuModule,
                Customers = module

            };
            return View(model);
        }

        private readonly ICustomerAppService _CustomerAppService;

        public CustomerController(ICustomerAppService CustomerAppService)
        {
            _CustomerAppService = CustomerAppService;

        }
        public async Task<ActionResult> EditCustomerModal(int moduleId)

        {
            var module = await _CustomerAppService.Get(new EntityDto<int>(moduleId));
            CreateUpdateCustomerDto cuCustomer = AutoMapper.Mapper.Map<CreateUpdateCustomerDto>(module);
            var model = new EditCustomerModalViewModel
            {
                Customer = cuCustomer

            };
            return View("_EditCustomerModal", model);
        }
    }
}