using System.Web.Mvc;

namespace WorkOrder.Web.Controllers
{
    public class AboutController : WorkOrderControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}