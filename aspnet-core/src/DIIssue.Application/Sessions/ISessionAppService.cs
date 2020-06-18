using System.Threading.Tasks;
using Abp.Application.Services;
using DIIssue.Sessions.Dto;

namespace DIIssue.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
