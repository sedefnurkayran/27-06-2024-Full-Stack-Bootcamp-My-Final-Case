using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework
{

    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {

        private Context _context;

        public EfBlogRepository(Context context) : base(context)
        {
            _context = context;
        }
        //ORJ bu

        public List<Blog> GetBlogListWithCategory()
        {
            // using (var c = new Context())
            {
                return _context.blogs.Include(x => x.Category).ToList();
            }
            // return _context.blogs.Include(x => x.Category).ToList();

        }



        public List<Blog> GetBlogListWithCategoryByWriter(int id)
        {
            {
                return _context.blogs.Include(x => x.Category).Where(x => x.WriterId == id).ToList();
            }
        }
    }
}