using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JD.Invoicing.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace JD.Invoicing.Warehouse.Dto
{

    [AutoMapFrom(typeof(Entitys.Warehouse))]
    public class WarehouseDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Sizes { get; set; }
        public string Purpose { get; set; }
        public string Remarks { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateName { get; set; }
        public DateTime CreationTime { get; set; }
    }
}