using Abp.Application.Services;
using bichtram.MultiTenancy.Dto;

namespace bichtram.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

