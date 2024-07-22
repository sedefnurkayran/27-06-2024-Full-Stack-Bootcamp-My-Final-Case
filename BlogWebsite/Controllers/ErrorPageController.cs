using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class ErrorPageController : Controller
    {

        public IActionResult Error1(int code)
        {

            return View();
        }

    }

}