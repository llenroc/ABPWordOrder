using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;
using WorkOrder.Authorization;
using WorkOrder.MultiTenancy;

namespace WorkOrder.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Tenants)]
    public class TenantsController : WorkOrderControllerBase
    {
        private readonly ITenantAppService _tenantAppService;

        public TenantsController(ITenantAppService tenantAppService)
        {
            _tenantAppService = tenantAppService;
        }

        public ActionResult Index()
        {
            var output = _tenantAppService.GetTenants();
            return View(output);
        }
    }
}