using BlogWebsite.DAL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace BlogWebsite.Controllers;

public class BlogController : Controller
{
    private IBlogRepository _repository;
    public BlogController(IBlogRepository repository)
    {
        _repository = repository;
    }
    public IActionResult Index()
    {
        return View(_repository.Blogs.ToList());
    }
}