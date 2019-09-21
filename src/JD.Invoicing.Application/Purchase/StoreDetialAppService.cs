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

    public class StoreDetialAppService : AsyncCrudAppService<Entitys.StoreDetial, StoreDetialDto, int, PagedResultRequestDto,
                             CreateUpdateStoreDetialDto, CreateUpdateStoreDetialDto>, IStoreDetialAppService

    {

        public StoreDetialAppService(IRepository<StoreDetial, int> repository)
            : base(repository)
        {

        }

        public override Task<StoreDetialDto> Create(CreateUpdateStoreDetialDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}