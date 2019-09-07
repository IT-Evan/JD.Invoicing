using System.Threading.Tasks;
using Abp.Application.Services;
using JD.Invoicing.Authorization.Accounts.Dto;

namespace JD.Invoicing.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
