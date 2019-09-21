using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class StoreDetialListViewModel
    {
        public IReadOnlyList<StoreDetialDto> StoreDetials { get; set; }
    }
}