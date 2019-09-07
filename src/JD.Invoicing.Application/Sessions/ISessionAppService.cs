using System.Threading.Tasks;
using Abp.Application.Services;
using JD.Invoicing.Sessions.Dto;

namespace JD.Invoicing.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
