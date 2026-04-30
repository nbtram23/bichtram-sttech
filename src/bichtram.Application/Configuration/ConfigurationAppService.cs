using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using bichtram.Configuration.Dto;

namespace bichtram.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : bichtramAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
