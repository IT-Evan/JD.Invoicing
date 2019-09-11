using System.Collections.Generic;
using JD.Invoicing.Customer.Dto;

namespace JD.Invoicing.Web.Models.Customer
{

    public class CustomerListViewModel
    {
        //public CustomerDto Customer { get; set; }
        public IReadOnlyList<CustomerDto> Customers { get; set; }
    }
}