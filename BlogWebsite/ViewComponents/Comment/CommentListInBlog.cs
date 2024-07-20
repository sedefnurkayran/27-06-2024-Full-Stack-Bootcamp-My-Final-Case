using System.Runtime.InteropServices;
using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Comment
{

    public class CommentListInBlog : ViewComponent
    {
        // CommentManager cm = new CommentManager(new EfCommentRepository()); MY 

        private readonly CommentManager cm;

        public CommentListInBlog(DataContext context)
        {
            cm = new CommentManager(new EfCommentRepository(context));
        }
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}