using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Authorization;
using Abp.Localization;

namespace JD.Invoicing.Roles.Dto
{
    [AutoMapFrom(typeof(Permission))]
    public class PermissionDto : EntityDto<long>
    {
        public long ParentID { get; set; }
        public string Name { get; set; }
        public ILocalizableString DisplayName { get; set; }
        public ILocalizableString Description { get; set; }
    }
}
