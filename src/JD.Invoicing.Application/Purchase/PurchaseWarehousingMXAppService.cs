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

    public class PurchaseWarehousingMXAppService : AsyncCrudAppService<Entitys.PurchaseWarehousingMX, PurchaseWarehousingMXDto, int, PagedResultRequestDto,
                             CreateUpdatePurchaseWarehousingMXDto, CreateUpdatePurchaseWarehousingMXDto>, IPurchaseWarehousingMXAppService

    {

        public PurchaseWarehousingMXAppService(IRepository<PurchaseWarehousingMX, int> repository)
            : base(repository)
        {

        }

        public override Task<PurchaseWarehousingMXDto> Create(CreateUpdatePurchaseWarehousingMXDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}