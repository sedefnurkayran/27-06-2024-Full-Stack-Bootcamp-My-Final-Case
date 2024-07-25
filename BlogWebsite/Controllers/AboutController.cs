using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;

namespace BlogWebsite.Controllers;
[Authorize]
public class AboutController : Controller
{
    //AboutManager abm = new AboutManager(new EfAboutRepository());  //MY

    private readonly AboutManager abm;

    public AboutController(Context context)
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