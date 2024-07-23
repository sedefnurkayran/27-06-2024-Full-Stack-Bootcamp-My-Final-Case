using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class ContactController : Controller
    {
        //CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //MY

        private readonly ContactManager cm;

        public ContactController(DataContext context)
        {
            cm = new ContactManager(new EfContactRepository(context));
        }


        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Index(Contact contact)
        {
            contact.ContactDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            contact.ContactStatus = true;
            cm.AddContact(contact);
            return RedirectToAction("Index", "Blog");
        }
    }
}