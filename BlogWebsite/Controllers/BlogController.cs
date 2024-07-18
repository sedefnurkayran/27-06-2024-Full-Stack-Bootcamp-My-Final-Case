using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class BlogController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}