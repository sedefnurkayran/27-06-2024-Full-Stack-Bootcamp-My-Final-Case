
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {

        // private DataContext _context;
        public EfCommentRepository(DataContext context) : base(context)
        {
            //  _context = context;
        }
    }
}