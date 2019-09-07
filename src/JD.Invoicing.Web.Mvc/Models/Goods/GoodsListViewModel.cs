using System.Collections.Generic;
using JD.Invoicing.Goods.Dto;

namespace JD.Invoicing.Web.Models.Goods
{

    public class GoodsListViewModel
    {
        public GoodsDto Goods { get; set; }
        public IReadOnlyList<GoodsDto> Goodses { get; set; }
    }
}