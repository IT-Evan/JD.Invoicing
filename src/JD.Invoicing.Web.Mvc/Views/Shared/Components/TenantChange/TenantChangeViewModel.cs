using Abp.AutoMapper;
using JD.Invoicing.Sessions.Dto;

namespace JD.Invoicing.Web.Views.Shared.Components.TenantChange
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}
