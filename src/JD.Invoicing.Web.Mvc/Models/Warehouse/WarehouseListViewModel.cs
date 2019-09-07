using System.Collections.Generic;
using JD.Invoicing.Warehouse.Dto;

namespace JD.Invoicing.Web.Models.Warehouse
{

    public class WarehouseListViewModel
    {
        public WarehouseDto Warehouse { get; set; }
        public IReadOnlyList<WarehouseDto> Warehouses { get; set; }
    }
}