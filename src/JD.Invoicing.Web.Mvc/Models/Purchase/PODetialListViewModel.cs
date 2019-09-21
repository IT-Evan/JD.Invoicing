using System.Collections.Generic;
using JD.Invoicing.Purchase.Dto;

namespace JD.Invoicing.Web.Models.Purchase
{

    public class PODetialListViewModel
    {
        public IReadOnlyList<PODetialDto> PODetials { get; set; }
    }
}