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

        public List<Blog> GetLast3Blog()
        {
            return _blogDal.GetAllList().Take(3).ToList();
        }

        public List<Blog> GetBlogById(int id)
        {

            return _blogDal.GetAllList(x => x.BlogId == id);
        }
        public void UpdateBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogListOfWriter(int id)
        {
            return _blogDal.GetAllList(x => x.WriterId == id);
        }
    }
}