
using BlogWebsite.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{
    public class ContactController : Controller
    {
        // CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //MY

        private readonly ContactManager cm;

        public ContactController(Context context)
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