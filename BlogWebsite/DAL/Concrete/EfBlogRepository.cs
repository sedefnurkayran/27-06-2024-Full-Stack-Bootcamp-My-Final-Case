using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

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
    }
}