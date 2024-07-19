using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Concrete
{
    public class BlogManager : IBlogService
    {
        //constructor
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {

            _blogDal = blogDal;
        }
        //
        public void AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetBlogListWithCategory();
        }

        public Blog GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetList()
        {
            return _blogDal.GetAllList();
        }

        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }
    }
}