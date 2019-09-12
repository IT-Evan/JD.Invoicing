using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using JD.Invoicing.Authorization;
using JD.Invoicing.Controllers;
using JD.Invoicing.Customer;
using JD.Invoicing.Customer.Dto;
using JD.Invoicing.Web.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace JD.Invoicing.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Customer)]
    public class CustomerController : InvoicingControllerBase
    {
        private readonly ICustomerAppService _customerAppService;
        const int MaxNum = 10;
        public CustomerController(ICustomerAppService customerAppService)
        {
            _customerAppService = customerAppService;

        }
        // GET: /<controller>/
        public async Task<ActionResult> Index()
        {
            var customers = (await _customerAppService.GetAll(new PagedResultRequestDto { MaxResultCount = MaxNum })).Items;
            // Paging not implemented yet
            //CustomerDto cuModule = customers.FirstOrDefault();
            var model = new CustomerListViewModel
            {
                //Customer = cuModule,
                Customers = customers
            };
            return View(model);
        }
        
        public async Task<ActionResult> EditCustomerModal(int customerId)
        {
            var customer = await _customerAppService.Get(new EntityDto<int>(customerId));
            //CreateUpdateCustomerDto cuCustomer = AutoMapper.Mapper.Map<CreateUpdateCustomerDto>(customer);
            var model = new EditCustomerModalViewModel
            {
                Customer = customer
            };
            return View("_EditCustomerModal", model);
        }
    }
}