
using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.ViewComponents
{

    public class BlogLast3Post : ViewComponent
    {
        private readonly BlogManager bm;

        public BlogLast3Post(DataContext context)
        {
            bm = new BlogManager(new EfBlogRepository(context));
        }

        public IViewComponentResult Invoke()
        {
            var blogs = bm.GetLast3Blog();
            return View(blogs);
        }
    }
}