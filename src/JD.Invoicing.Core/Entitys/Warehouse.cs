using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JD.Invoicing.Entitys
{
    public class Warehouse : Entity<int>, IHasCreationTime
    {
        public Warehouse()
        {
            this.Code = string.Empty;
            this.Name = string.Empty;
            this.Address = string.Empty;
            this.Sizes = string.Empty;
            this.Purpose = string.Empty;
            this.Remarks = string.Empty;
            this.Status = null;
            this.CreateDate = null;
            this.CreateName = string.Empty;
            this.UpdateDate = null;
            this.UpdateName = string.Empty;
            this.CreationTime = Clock.Now;
        }

        /// <summary>
        /// 仓库编号
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Code { get; set; }
        /// <summary>
        /// 仓库名称
        /// </summary>
        [StringLength(150)]
        public string Name { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(200)]
        public string Address { get; set; }
        /// <summary>
        /// 面积
        /// </summary>
        [StringLength(50)]
        public string Sizes { get; set; }
        /// <summary>
        /// 用途描述
        /// </summary>
        [StringLength(500)]
        public string Purpose { get; set; }
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