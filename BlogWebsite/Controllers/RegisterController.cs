using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class RegisterController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

}