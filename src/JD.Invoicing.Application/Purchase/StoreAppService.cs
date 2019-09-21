﻿using Abp.Application.Services;
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

    public class StoreAppService : AsyncCrudAppService<Entitys.Store, StoreDto, int, PagedResultRequestDto,
                             CreateUpdateStoreDto, CreateUpdateStoreDto>, IStoreAppService

    {

        public StoreAppService(IRepository<Store, int> repository)
            : base(repository)
        {

        }

        public override Task<StoreDto> Create(CreateUpdateStoreDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}