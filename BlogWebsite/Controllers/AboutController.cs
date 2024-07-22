using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace BlogWebsite.Controllers;

public class AboutController : Controller
{
    //AboutManager abm = new AboutManager(new EfAboutRepository());MY

    private readonly AboutManager abm;

    public AboutController(DataContext context)
    {
        abm = new AboutManager(new EfAboutRepository(context));
    }

    public IActionResult Index()
    {
        var values = abm.GetList();

        return View(values);
    }

    public PartialViewResult SocialMediaAbout()
    {
        return PartialView();
    }

}