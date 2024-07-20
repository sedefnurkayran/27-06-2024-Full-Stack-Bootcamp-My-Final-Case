using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.BusinessLayer.ValidationRules;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using FluentValidation.Results;
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
        WriterValidator wv = new WriterValidator();
        ValidationResult result = wv.Validate(user);

        if (result.IsValid)
        {
            user.UserStatus = true;
            user.UserAbout = "Deneme";
            rm.AddWriter(user);
            return RedirectToAction("Index", "Blog");
        }
        else
        {
            foreach (var item in result.Errors)
            {
                ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            }
        }
        return View();
    }
}