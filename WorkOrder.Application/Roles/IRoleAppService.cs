using System.Threading.Tasks;
using Abp.Application.Services;
using WorkOrder.Roles.Dto;

namespace WorkOrder.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
