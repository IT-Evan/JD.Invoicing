using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using JD.Invoicing.Configuration.Dto;

namespace JD.Invoicing.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : InvoicingAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
