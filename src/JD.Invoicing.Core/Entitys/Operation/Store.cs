﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;

namespace JD.Invoicing.Entitys
{
    public class Store : Entity<int>, IHasCreationTime
    {
        public Store()
        {
            this.OrderID = string.Empty;
            this.OrderDate = null;
            this.OrderType = string.Empty;
            this.CreateDate = null;
            this.CreateName = string.Empty;
            this.YSNameID = 0;
            this.YSName = string.Empty;
            this.Sup_id = 0;
            this.SupName = null;
            this.StroeInfo_id = 0;
            this.StoreName = null;
            this.Sum = null;
            this.BZ = string.Empty;
            this.SHStatus = null;
            this.SHDate = null;
            this.SHName = string.Empty;
            this.OrderOrder_id = null;
            this.OrderOrderID = string.Empty;
            this.CreationTime = Clock.Now;
        }
        /// <summary>
        /// 单据编号
        /// </summary>
        [StringLength(45)]
        public string OrderID { get; set; }
        /// <summary>
        /// 单据日期
        /// </summary>
        public DateTime? OrderDate { get; set; }
        /// <summary>
        /// 单据类型IS入库。BR出库
        /// </summary>
        [StringLength(10)]
        public string OrderType { get; set; }
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
        /// 验收ID
        /// </summary>
        public int YSNameID { get; set; }
        /// <summary>
        /// 验收员
        /// </summary>
        [StringLength(45)]
        public string YSName { get; set; }
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
        /// 仓库ID
        /// </summary>
        public int StroeInfo_id { get; set; }
        /// <summary>
        /// 仓库ID
        /// </summary>
        [StringLength(45)]
        public string StoreName { get; set; }
        /// <summary>
        /// 总金额
        /// </summary>
        public decimal? Sum { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(200)]
        public string BZ { get; set; }
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
        /// <summary>
        /// 关联订单号id
        /// </summary>
        public int? OrderOrder_id { get; set; }
        /// <summary>
        /// 关联订单号单据编号
        /// </summary>
        [StringLength(45)]
        public string OrderOrderID { get; set; }

        public virtual List<StoreDetial> PurchaseWarehousingMX { get; set; }

        public DateTime CreationTime { get; set; }
    }
}
