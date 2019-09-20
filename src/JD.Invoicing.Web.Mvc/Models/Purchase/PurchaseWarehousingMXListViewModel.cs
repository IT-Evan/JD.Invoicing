using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class PurchaseWarehousingMXListViewModel
    {
        public IReadOnlyList<PurchaseWarehousingMXDto> PurchaseWarehousingMXs { get; set; }
    }
}