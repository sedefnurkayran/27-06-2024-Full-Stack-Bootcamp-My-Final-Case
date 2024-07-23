
using BlogWebsite.DAL.Abstract;
using BlogWebsite.DAL.Concrete.EfCore;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {

        public EfAboutRepository(DataContext context) : base(context)
        {
        }

        //  private DataContext _context;

        // public EfAboutRepository(DataContext context)
        // {
        //     _context = context;
        // }

    }
}