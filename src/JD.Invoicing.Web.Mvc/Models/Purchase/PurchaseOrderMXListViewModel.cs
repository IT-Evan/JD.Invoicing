using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class PurchaseOrderMXListViewModel
    {
        public IReadOnlyList<PurchaseOrderMXDto> PurchaseOrderMXs { get; set; }
    }
}