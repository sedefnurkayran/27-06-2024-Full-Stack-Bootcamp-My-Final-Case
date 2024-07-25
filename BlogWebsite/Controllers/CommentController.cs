
using BlogWebsite.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class CommentController : Controller
    {

        private readonly CommentManager cm;

        public CommentController(Context context)
        {
            cm = new CommentManager(new EfCommentRepository(context));
        }

        [HttpGet]
        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult PartialAddComment(Comment comment)
        {
            comment.CommentCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            comment.BlogId = 1;
            comment.CommentStatus = true;
            cm.AddComment(comment);
            return PartialView();
        }
        public PartialViewResult CommentListInBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}