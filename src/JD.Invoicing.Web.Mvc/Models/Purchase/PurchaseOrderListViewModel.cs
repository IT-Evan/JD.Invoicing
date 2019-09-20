using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class PurchaseOrderListViewModel
    {
        public IReadOnlyList<PurchaseOrderDto> PurchaseOrders { get; set; }
    }
}