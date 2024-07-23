using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class WriterController : Controller
{
    // private readonly BlogManager bm;

    // public WriterController(DataContext context)
    // {
    //     bm = new BlogManager(new EfWriterRepository(context));
    // }
    //[Authorize]
    [AllowAnonymous]
    public IActionResult Index()
    {
        //  var values = bm.GetBlogListWithCategory();
        return View();
    }


    public IActionResult WriterProfile()
    {
        return View();
    }
    public IActionResult WriterMail()
    {
        return View();
    }
}