using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Abstract
{
    public interface IBlogService
    {
        // void AddBlog(Blog blog);
        // void DeleteBlog(Blog blog);
        // void UpdateBlog(Blog blog);
        // List<Blog> GetList();
        // Blog GetById(int id);

        List<Blog> GetBlogListWithCategory(); //Kategorilere gore bloglari listeleme

        List<Blog> GetBlogListOfWriter(int id); //Yazarin son 3 postu.


    }
}