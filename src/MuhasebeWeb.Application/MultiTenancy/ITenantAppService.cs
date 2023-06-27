using Abp.Application.Services;
using MuhasebeWeb.MultiTenancy.Dto;

namespace MuhasebeWeb.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

