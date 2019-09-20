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

    public class PurchaseOrderMXAppService : AsyncCrudAppService<Entitys.PurchaseOrderMX, PurchaseOrderMXDto, int, PagedResultRequestDto,
                             CreateUpdatePurchaseOrderMXDto, CreateUpdatePurchaseOrderMXDto>, IPurchaseOrderMXAppService

    {

        public PurchaseOrderMXAppService(IRepository<PurchaseOrderMX, int> repository)
            : base(repository)
        {

        }

        public override Task<PurchaseOrderMXDto> Create(CreateUpdatePurchaseOrderMXDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}