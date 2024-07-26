using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{

    public class BlogManager : IBlogService
    {
        //constructor
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {

            _blogDal = blogDal;
        }

        // public void AddBlog(Blog blog)
        // {
        //     throw new NotImplementedException();
        // }

        // public void DeleteBlog(Blog blog)
        // {
        //     throw new NotImplementedException();
        // }
        // public void UpdateBlog(Blog blog)
        // {
        //     throw new NotImplementedException();
        // }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetBlogListWithCategory();
        }



        public List<Blog> GetBlogListWithCategoryByWriterBm(int id)
        {
            return _blogDal.GetBlogListWithCategoryByWriter(id);
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

        public List<Blog> GetBlogListOfWriter(int id)
        {
            return _blogDal.GetAllList(x => x.WriterId == id);
        }

        public void TAdd(Blog t)
        {
            _blogDal.Insert(t);
        }

        public void TDelete(Blog t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Blog t)
        {
            throw new NotImplementedException();
        }


    }
}