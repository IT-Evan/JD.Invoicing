using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class POListViewModel
    {
        public IReadOnlyList<PODto> POs { get; set; }
    }
}