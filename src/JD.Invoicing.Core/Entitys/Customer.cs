using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JD.Invoicing.Entitys
{
    public class Customer : Entity<int>, IHasCreationTime
    {
        public Customer()
        {
            this.Code = string.Empty;
            this.Name = string.Empty;
            this.PinyinCode = string.Empty;
            this.Address = string.Empty;
            this.Contact = string.Empty;
            this.Phone = string.Empty;
            this.Wechat = string.Empty;
            this.Area = string.Empty;
            this.Type = null;
            this.Remarks = string.Empty;
            this.Status = null;
            this.CreateDate = null;
            this.CreateName = string.Empty;
            this.UpdateDate = null;
            this.UpdateName = string.Empty;
            this.CreationTime = Clock.Now;
        }

        /// <summary>
        /// 客商编号
        /// </summary>
        [StringLength(50)]
        public string Code { get; set; }
        /// <summary>
        /// 客商名称
        /// </summary>
        [StringLength(150)]
        public string Name { get; set; }
        /// <summary>
        /// 拼音码
        /// </summary>
        [StringLength(150)]
        public string PinyinCode { get; set; }
        /// <summary>
        /// 地址
        /// </summary>
        [StringLength(200)]
        public string Address { get; set; }
        /// <summary>
        /// 联系人
        /// </summary>
        [StringLength(50)]
        public string Contact { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        [StringLength(50)]
        public string Phone { get; set; }
        /// <summary>
        /// 微信
        /// </summary>
        [StringLength(50)]
        public string Wechat { get; set; }
        /// <summary>
        /// 所属区域
        /// </summary>
        [StringLength(50)]
        public string Area { get; set; }
        /// <summary>
        /// 客商类别
        /// </summary>
        public int? Type { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [StringLength(200)]
        public string Remarks { get; set; }
        /// <summary>
        /// 状态
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