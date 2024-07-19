using BlogWebsite.Models;

namespace BlogWebsite.DAL.Abstract
{

    public interface IBlogRepository
    {
        IQueryable<Blog> Blogs { get; }
        void CreateBlog(Blog blog);

        //sdf
        void DeleteBlog(Blog blog);
        void UpdateBlog(Blog blog);
        Blog GetById(int id);
    }

}