﻿using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JD.Invoicing.Entitys
{
    public class Goods : Entity<int>, IHasCreationTime
    {
        public Goods()
        {
            this.Code = string.Empty;
            this.Name = string.Empty;
            this.GenericName = string.Empty;
            this.PinyinCode = string.Empty;
            this.Barcode = string.Empty;
            this.Unit = string.Empty;
            this.Specs = string.Empty;
            this.Model = string.Empty;
            this.Manufacturer = string.Empty;
            this.License = string.Empty;
            this.Class = string.Empty;
            this.Type = string.Empty;
            this.RetailPrice = 0;
            this.Remarks = string.Empty;
            this.Status = null;
            this.CreateDate = null;
            this.CreateName = string.Empty;
            this.UpdateDate = null;
            this.UpdateName = string.Empty;
            this.CreationTime = Clock.Now;
        }

        /// <summary>
        /// 商品编号
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        /// <summary>
        /// 商品名称
        /// </summary>
        [Required]
        [StringLength(150)]
        public string Name { get; set; }
        /// <summary>
        /// 通用名
        /// </summary>
        [StringLength(150)]
        public string GenericName { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [StringLength(150)]
        public string PinyinCode { get; set; }
        /// <summary>
        /// 条形码
        /// </summary>
        [StringLength(100)]
        public string Barcode { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        [StringLength(50)]
        public string Unit { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        [StringLength(50)]
        public string Specs { get; set; }
        /// <summary>
        /// 型号
        /// </summary>
        [StringLength(50)]
        public string Model { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        [StringLength(150)]
        public string Manufacturer { get; set; }
        /// <summary>
        /// 许可证
        /// </summary>
        [StringLength(150)]
        public string License { get; set; }
        /// <summary>
        /// 大纲类别
        /// </summary>
        [StringLength(50)]
        public string Class { get; set; }
        /// <summary>
        /// 所属分类
        /// </summary>
        [StringLength(50)]
        public string Type { get; set; }
        /// <summary>
        /// 零售价
        /// </summary>
        public decimal RetailPrice { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(200)]
        public string Remarks { get; set; }
        /// <summary>
        /// 状态1 正常 2删除
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        [StringLength(50)]
        public string CreateName { get; set; }
        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime? UpdateDate { get; set; }
        /// <summary>
        /// 修改人
        /// </summary>
        [StringLength(50)]
        public string UpdateName { get; set; }

        public DateTime CreationTime { get; set; }
    }
}