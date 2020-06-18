using System.Threading.Tasks;
using DIIssue.Configuration.Dto;

namespace DIIssue.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
