using Abp.Application.Services;
using Abp.Application.Services.Dto;
using yuknikah.MultiTenancy.Dto;

namespace yuknikah.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

