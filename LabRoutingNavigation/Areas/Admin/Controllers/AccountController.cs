using LabRoutingNavigation.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabRoutingNavigation.Areas.Admin.Controllers
{
    public class AccountController : BaseController
    {
        public IActionResult Profile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            return View();
        }
    }
}
