using System.Threading.Tasks;
using Abp.Application.Services;
using DIIssue.Authorization.Accounts.Dto;

namespace DIIssue.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
