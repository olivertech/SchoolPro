using Microsoft.AspNetCore.Mvc;

namespace SchoolPro.Api.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
