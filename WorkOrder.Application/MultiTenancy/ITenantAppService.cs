using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using WorkOrder.MultiTenancy.Dto;

namespace WorkOrder.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
