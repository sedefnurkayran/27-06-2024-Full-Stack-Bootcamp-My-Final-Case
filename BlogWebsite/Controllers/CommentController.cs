using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class CommentController : Controller
    {


        public PartialViewResult PartialAddComment()
        {
            return PartialView();
        }

        public PartialViewResult CommentListInBlog()
        {
            return PartialView();
        }
    }
}