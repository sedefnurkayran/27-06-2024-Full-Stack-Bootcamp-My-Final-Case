
using BlogWebsite.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class NewsLetterController : Controller
    {

        private readonly NewsLetterManager nm;

        public NewsLetterController(Context context)
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