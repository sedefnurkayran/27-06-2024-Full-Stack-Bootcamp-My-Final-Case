using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class NewsLetterController : Controller
    {

        private readonly NewsLetterManager nm;

        public NewsLetterController(DataContext context)
        {
            nm = new NewsLetterManager(new EfNewsLetterRepository(context));
        }


        [HttpGet]
        public PartialViewResult SubscribeMail()
        {

            return PartialView();
        }

        [HttpPost]
        public PartialViewResult SubscribeMail(NewsLetter newsLetter)
        {
            newsLetter.MailStatus = true;
            nm.AddNewsLetter(newsLetter);
            return PartialView();
        }
    }
}