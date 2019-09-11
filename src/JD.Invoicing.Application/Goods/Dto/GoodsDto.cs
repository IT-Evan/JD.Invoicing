using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using JD.Invoicing.Entitys;
using System;
using System.Collections.Generic;
using System.Text;

namespace JD.Invoicing.Goods.Dto
{

    [AutoMapFrom(typeof(Entitys.Goods))]
    public class GoodsDto : EntityDto<int>
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string GenericName { get; set; }
        public string PinyinCode { get; set; }
        public string Barcode { get; set; }
        public string Unit { get; set; }
        public string Specs { get; set; }
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string License { get; set; }
        public string Class { get; set; }
        public string Type { get; set; }
        public decimal RetailPrice { get; set; }
        public string Remarks { get; set; }
        public int? Status { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateName { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateName { get; set; }
        public DateTime CreationTime { get; set; }
    }
}