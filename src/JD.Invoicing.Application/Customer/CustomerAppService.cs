using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using JD.Invoicing.Entitys;
using JD.Invoicing.Customer.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JD.Invoicing.Customer
{

    public class CustomerAppService : AsyncCrudAppService<Entitys.Customer, CustomerDto, int, PagedResultRequestDto,
                             CreateUpdateCustomerDto, CreateUpdateCustomerDto>, ICustomerAppService

    {

        public CustomerAppService(IRepository<Entitys.Customer, int> repository)
            : base(repository)
        {

        }

        public override Task<CustomerDto> Create(CreateUpdateCustomerDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}