using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;
using Microsoft.AspNetCore.Http.HttpResults;

namespace BlogWebsite.DAL.Concrete
{

    public class EfBlogRepository : IBlogRepository
    {
        private DataContext _context;

        public EfBlogRepository(DataContext context)
        {
            _context = context;
        }
        public IQueryable<Blog> Blogs => _context.blogs;

        //public IQueryable<Blog> Blogs => throw new NotImplementedException();

        public void CreateBlog(Blog blog)
        {
            _context.blogs.Add(blog);
            _context.SaveChanges();
        }
        //SDF
        public void DeleteBlog(Blog blog)
        {
            _context.blogs.Remove(blog);
            _context.SaveChanges();
        }

        public Blog GetById(int id)
        {
            //return _context.blogs.Find(id);

            var blog = _context.blogs.Find(id);
            if (blog == null)
            {
                throw new Exception("Blog not found");
            }

            return blog;
        }

        public void UpdateBlog(Blog blog)
        {
            _context.blogs.Update(blog);
            _context.SaveChanges();
        }
    }
}