using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class AboutController : Controller
    {

        public IActionResult Index()
        {
            return View();

        }
    }
}