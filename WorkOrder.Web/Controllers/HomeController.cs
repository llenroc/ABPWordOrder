using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace WorkOrder.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : WorkOrderControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}