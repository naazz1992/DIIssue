using Abp.Application.Services;
using DIIssue.MultiTenancy.Dto;

namespace DIIssue.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

