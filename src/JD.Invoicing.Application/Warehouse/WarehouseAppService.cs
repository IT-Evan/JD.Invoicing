using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using JD.Invoicing.Entitys;
using JD.Invoicing.Warehouse.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JD.Invoicing.Warehouse
{

    public class WarehouseAppService : AsyncCrudAppService<Entitys.Warehouse, WarehouseDto, int, PagedResultRequestDto,
                             CreateUpdateWarehouseDto, CreateUpdateWarehouseDto>, IWarehouseAppService

    {

        public WarehouseAppService(IRepository<Entitys.Warehouse, int> repository)
            : base(repository)
        {

        }

        public override Task<WarehouseDto> Create(CreateUpdateWarehouseDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}