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

    public class PurchaseOrderAppService : AsyncCrudAppService<Entitys.PurchaseOrder, PurchaseOrderDto, int, PagedResultRequestDto,
                             CreateUpdatePurchaseOrderDto, CreateUpdatePurchaseOrderDto>, IPurchaseOrderAppService

    {

        public PurchaseOrderAppService(IRepository<PurchaseOrder, int> repository)
            : base(repository)
        {

        }

        public override Task<PurchaseOrderDto> Create(CreateUpdatePurchaseOrderDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}