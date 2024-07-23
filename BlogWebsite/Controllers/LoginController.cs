using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace BlogWebsite.Controllers
{

    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }


        [AllowAnonymous]
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer writer)
        {
            //DataContext c = new DataContext();
            var dataValue = _context.writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);

            if (dataValue != null)
            {
                //HttpContent.Session.SetString("username", user.UserMail);
                HttpContext.Session.SetString("username", writer.WriterMail ?? "");
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                return View();
            }

        }
    }
}