
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfWriterRepository : GenericRepository<User>, IWriterDal
    {

        public EfWriterRepository(DataContext context) : base(context)
        {
            //  _context = context;
        }
    }
}