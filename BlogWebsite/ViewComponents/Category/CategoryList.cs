using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Comment
{

    public class CategoryList : ViewComponent
    {
        // CommentManager cm = new CommentManager(new EfCommentRepository()); MY 

        private readonly CategoryManager cm;

        public CategoryList(DataContext context)
        {
            cm = new CategoryManager(new EfCategoryRepository(context));
        }
        public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}