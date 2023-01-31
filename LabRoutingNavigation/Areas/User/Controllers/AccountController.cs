using Microsoft.AspNetCore.Mvc;

namespace LabRoutingNavigation.Areas.User.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }

    }
}
