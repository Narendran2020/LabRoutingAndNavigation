using Microsoft.AspNetCore.Mvc;

namespace LabRoutingNavigation.Areas.User.Controllers
{
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
