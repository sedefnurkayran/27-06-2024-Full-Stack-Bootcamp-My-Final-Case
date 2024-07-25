
using BlogWebsite.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class RegisterController : Controller
{

    private readonly WriterManager rm;

    public RegisterController(Context context)
    {
        rm = new WriterManager(new EfWriterRepository(context));
    }


    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Writer writer)
    {
        WriterValidator wv = new WriterValidator();
        ValidationResult result = wv.Validate(writer);

        if (result.IsValid)
        {
            writer.WriterStatus = true;
            writer.WriterAbout = "Deneme";
            rm.AddWriter(writer);
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