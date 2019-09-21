using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class StoreListViewModel
    {
        public IReadOnlyList<StoreDto> Stores { get; set; }
    }
}