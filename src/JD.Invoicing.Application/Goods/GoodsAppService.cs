using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using JD.Invoicing.Entitys;
using JD.Invoicing.Goods.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JD.Invoicing.Goods
{

    public class GoodsAppService : AsyncCrudAppService<Entitys.Goods, GoodsDto, int, PagedResultRequestDto,
                             CreateUpdateGoodsDto, CreateUpdateGoodsDto>, IGoodsAppService

    {

        public GoodsAppService(IRepository<Entitys.Goods, int> repository)
            : base(repository)
        {

        }

        public override Task<GoodsDto> Create(CreateUpdateGoodsDto input)
        {
            var sin = input;
            return base.Create(input);
        }
    }
}