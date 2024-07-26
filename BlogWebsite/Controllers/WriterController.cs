
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

public class WriterController : Controller
{
    private readonly WriterManager wm;

    public WriterController(Context context)
    {
        wm = new WriterManager(new EfWriterRepository(context));
    }



    [Authorize]
    public IActionResult Index()
    {
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
    [AllowAnonymous]
    public IActionResult Test()
    {
        return View();
    }
    [AllowAnonymous]
    public PartialViewResult WriterNavbarPartial()
    {

        return PartialView();
    }

    [AllowAnonymous]
    public PartialViewResult WriterFooterPartial()
    {

        return PartialView();
    }
}