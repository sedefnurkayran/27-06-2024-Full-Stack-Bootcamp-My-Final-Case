using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class CommentController : Controller
    {

        private readonly CommentManager cm;

        public CommentController(DataContext context)
        {
            cm = new CommentManager(new EfCommentRepository(context));
        }


        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListInBlog(int id)
        {
            var values = cm.GetList(id);
            return PartialView(values);
        }
    }
}