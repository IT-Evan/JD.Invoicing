using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using JD.Invoicing.Entitys;
using JD.Invoicing.Purchase.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JD.Invoicing.Purchase
{

    public class POAppService : AsyncCrudAppService<Entitys.PO, PODto, int, PagedResultRequestDto,
                             CreateUpdatePODto, CreateUpdatePODto>, IPOAppService

    {

        public POAppService(IRepository<PO, int> repository)
            : base(repository)
        {

        }

        public override Task<PODto> Create(CreateUpdatePODto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}