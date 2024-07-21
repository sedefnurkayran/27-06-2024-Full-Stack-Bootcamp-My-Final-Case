using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class LoginController : Controller
    {

        public IActionResult Index()
        {

            return View();
        }
    }
}