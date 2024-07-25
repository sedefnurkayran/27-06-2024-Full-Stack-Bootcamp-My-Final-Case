
using BlogWebsite.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class CategoryController : Controller
    {
        // CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //MY

        private readonly CategoryManager cm;

        public CategoryController(Context context)
        {
            cm = new CategoryManager(new EfCategoryRepository(context));
        }

        public IActionResult Index()
        {
            var values = cm.GetList();

            return View(values);
        }
    }

}