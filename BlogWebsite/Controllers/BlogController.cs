// using System.ComponentModel.DataAnnotations;
// using BlogWebsite.BusinessLayer.Concrete;
// using BlogWebsite.BusinessLayer.ValidationRules;
// using BlogWebsite.DAL;
// using BlogWebsite.DAL.EntityFramework;
// using BlogWebsite.Models;
// using Microsoft.AspNetCore.Authorization;
// using Microsoft.AspNetCore.Mvc;
// using FluentValidation;
// using FluentValidation.Results;

using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.BusinessLayer.ValidationRules;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace BlogWebsite.Controllers;
[AllowAnonymous]
public class BlogController : Controller
{
    private readonly BlogManager bm;

    public BlogController(DataContext context)
    {
        bm = new BlogManager(new EfBlogRepository(context));
    }
    //BLOGLARIN LISTESI
    public IActionResult Index()
    {
        var values = bm.GetBlogListWithCategory();
        return View(values);
    }

    //BLOG DETAY SAYFASI
    public IActionResult BlogReadAll(int id)
    {
        ViewBag.i = id;
        var values = bm.GetBlogById(id);
        return View(values);
    }
    //YAZARLARA GORE BLOG GETIRME
    public IActionResult BlogListByWriter()
    {
        var values = bm.GetBlogListOfWriter(1);

        return View(values);

    }

    //SISTEME AUTHENTICE OLAN YAZAR BLOG EKLEYECEK
    [HttpGet]
    public IActionResult AddBlog()
    {

        return View();
    }
    [HttpPost]
    public IActionResult AddBlog(Blog blog)
    {
        BlogValidator bv = new BlogValidator();
        ValidationResult result = bv.Validate(blog);

        if (result.IsValid)
        {
            blog.BlogStatus = true;
            blog.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            blog.WriterId = 1;
            bm.TAdd(blog);
            return RedirectToAction("BlogListByWriter", "Blog");
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