using Abp.Authorization;
using WorkOrder.Authorization.Roles;
using WorkOrder.MultiTenancy;
using WorkOrder.Users;

namespace WorkOrder.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
