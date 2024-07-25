
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.ViewComponents.Comment
{

    public class CategoryList : ViewComponent
    {
        //CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //MY 

        private readonly CategoryManager cm;

        public CategoryList(Context context)
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