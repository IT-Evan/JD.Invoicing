using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class PurchaseWarehousingListViewModel
    {
        public IReadOnlyList<PurchaseWarehousingDto> PurchaseWarehousings { get; set; }
    }
}