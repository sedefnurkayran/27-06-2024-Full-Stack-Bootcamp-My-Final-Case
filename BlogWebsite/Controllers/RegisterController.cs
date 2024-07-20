using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class RegisterController : Controller
{

    private readonly WriterManager rm;

    public RegisterController(DataContext context)
    {
        rm = new WriterManager(new EfWriterRepository(context));
    }


    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(User user)
    {
        user.UserStatus = true;
        user.UserAbout = "Deneme";
        rm.AddWriter(user);
        return RedirectToAction("Index", "Blog");
    }
}