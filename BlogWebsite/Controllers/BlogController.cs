using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class BlogController : Controller
{
    private readonly BlogManager bm;

    public BlogController(DataContext context)
    {
        bm = new BlogManager(new EfBlogRepository(context));
    }

    public IActionResult Index()
    {
        var values = bm.GetBlogListWithCategory();
        return View(values);
    }

    public IActionResult BlogReadAll(int id)
    {
        ViewBag.i = id;
        var values = bm.GetBlogById(id);
        return View(values);
    }
}