using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DIIssue.Configuration.Dto;

namespace DIIssue.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DIIssueAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
