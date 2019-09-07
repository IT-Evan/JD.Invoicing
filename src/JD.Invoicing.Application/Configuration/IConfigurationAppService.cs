using System.Threading.Tasks;
using JD.Invoicing.Configuration.Dto;

namespace JD.Invoicing.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
