using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using yuknikah.Configuration.Dto;

namespace yuknikah.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : yuknikahAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
