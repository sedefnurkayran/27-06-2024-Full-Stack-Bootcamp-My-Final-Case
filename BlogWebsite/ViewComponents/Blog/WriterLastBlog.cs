using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.ViewComponents
{

    public class WriterLastBlog : ViewComponent
    {
        private readonly BlogManager bm;

        public WriterLastBlog(DataContext context)
        {
            bm = new BlogManager(new EfBlogRepository(context));
        }

        public IViewComponentResult Invoke()
        {
            var blogs = bm.GetBlogListOfWriter(1);
            return View(blogs);
        }
    }
}








