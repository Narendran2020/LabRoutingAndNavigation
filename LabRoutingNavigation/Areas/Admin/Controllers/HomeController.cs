using Microsoft.AspNetCore.Mvc;

namespace LabRoutingNavigation.Areas.Admin.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
