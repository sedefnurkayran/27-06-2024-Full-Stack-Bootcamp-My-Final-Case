using BlogWebsite.DAL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class BlogController : Controller
{
    private IBlogDal _repository;
    public BlogController(IBlogDal repository)
    {
        _repository = repository;
    }
    // public IActionResult Index()
    // {
    //     //return View(_repository.blog.ToList());
    // }
}