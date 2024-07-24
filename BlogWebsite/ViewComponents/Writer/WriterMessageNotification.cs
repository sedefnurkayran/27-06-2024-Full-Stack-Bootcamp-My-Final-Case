using BlogWebsite.DAL;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Writer
{

    public class WriterMessageNotification : ViewComponent
    {
        // CommentManager cm = new CommentManager(new EfCommentRepository()); MY 

        // private readonly CommentManager cm;

        // public WriterMessageNotification(DataContext context)
        // {
        //     cm = new CommentManager(new EfCommentRepository(context));
        // }
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}