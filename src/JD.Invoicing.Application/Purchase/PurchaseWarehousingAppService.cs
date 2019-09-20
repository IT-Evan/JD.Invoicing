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

    public class PurchaseWarehousingAppService : AsyncCrudAppService<Entitys.PurchaseWarehousing, PurchaseWarehousingDto, int, PagedResultRequestDto,
                             CreateUpdatePurchaseWarehousingDto, CreateUpdatePurchaseWarehousingDto>, IPurchaseWarehousingAppService

    {

        public PurchaseWarehousingAppService(IRepository<PurchaseWarehousing, int> repository)
            : base(repository)
        {

        }

        public override Task<PurchaseWarehousingDto> Create(CreateUpdatePurchaseWarehousingDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}