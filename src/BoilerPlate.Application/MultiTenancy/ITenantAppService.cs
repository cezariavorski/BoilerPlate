using Abp.Application.Services;
using Abp.Application.Services.Dto;
using BoilerPlate.MultiTenancy.Dto;

namespace BoilerPlate.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
