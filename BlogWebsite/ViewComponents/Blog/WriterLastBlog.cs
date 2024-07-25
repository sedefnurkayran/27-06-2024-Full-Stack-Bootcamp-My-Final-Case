using BusinessLayer;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.ViewComponents
{

    public class WriterLastBlog : ViewComponent
    {
        private readonly BlogManager bm;

        public WriterLastBlog(Context context)
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








