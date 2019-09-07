using Abp.Application.Services;
using Abp.Application.Services.Dto;
using JD.Invoicing.MultiTenancy.Dto;

namespace JD.Invoicing.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

