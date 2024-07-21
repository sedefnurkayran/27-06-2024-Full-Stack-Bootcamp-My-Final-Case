using BlogWebsite.BusinessLayer.Concrete;
using BlogWebsite.DAL;
using BlogWebsite.DAL.EntityFramework;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers
{

    public class CategoryController : Controller
    {
        //CategoryManager cm = new CategoryManager(new EfCategoryRepository()); //MY

        private readonly CategoryManager cm;

        public CategoryController(DataContext context)
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