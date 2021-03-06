﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities.Auditing;
using Abp.Domain.Entities;
using Abp.Timing;

namespace JD.Invoicing.Entitys
{
    public class PO : Entity<int>, IHasCreationTime
    {
        public PO()
        {
            this.OrderID = string.Empty;
            this.OrderDate = null;
            this.CreateDate = null;
            this.CreateName = string.Empty;
            this.CGNameID = 0;
            this.CGName = string.Empty;
            this.Sup_id = 0;
            this.SupName = string.Empty;
            this.BZ = string.Empty;
            this.Status = null;
            this.SHStatus = null;
            this.SHDate = null;
            this.SHName = string.Empty;
            this.PODetials = null;
            this.CreationTime = Clock.Now;
        }

        //// <summary>
        /// 单据编号
        /// </summary>
        [StringLength(45)]
        public string OrderID { get; set; }
        /// <summary>
        /// 单据日期
        /// </summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>
        /// 制单人日期
        /// </summary>
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 制单人
        /// </summary>
        [StringLength(45)]
        public string CreateName { get; set; }
        /// <summary>
        /// 采购员ID
        /// </summary>
        public int CGNameID { get; set; }
        /// <summary>
        /// 采购员
        /// </summary>
        [StringLength(45)]
        public string CGName { get; set; }
        /// <summary>
        /// 供应商id
        /// </summary>
        public int Sup_id { get; set; }
        /// <summary>
        /// 供应商
        /// </summary>
        [StringLength(145)]
        public string SupName { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(200)]
        public string BZ { get; set; }
        /// <summary>
        /// 完成状态 0未完成  1已完成
        /// </summary>
        public int? Status { get; set; }
        /// <summary>
        /// 审核状态 0未审核 1已审核
        /// </summary>
        public int? SHStatus { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public DateTime? SHDate { get; set; }
        /// <summary>
        /// 审核人
        /// </summary>
        [StringLength(45)]
        public string SHName { get; set; }

        public virtual List<PODetial> PODetials { get; set; }

        public DateTime CreationTime { get; set; }

    }
}
