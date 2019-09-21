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

    public class PODetialAppService : AsyncCrudAppService<Entitys.PODetial, PODetialDto, int, PagedResultRequestDto,
                             CreateUpdatePODetialDto, CreateUpdatePODetialDto>, IPODetialAppService

    {

        public PODetialAppService(IRepository<PODetial, int> repository)
            : base(repository)
        {

        }

        public override Task<PODetialDto> Create(CreateUpdatePODetialDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}