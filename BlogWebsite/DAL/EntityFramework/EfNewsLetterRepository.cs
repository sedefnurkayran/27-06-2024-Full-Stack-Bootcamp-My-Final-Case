using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfNewsLetterRepository : GenericRepository<NewsLetter>, INewsLetterDal
    {

        // EfNewsLetterRepository efNewsLetterRepository;
        // public EfNewsLetterRepository()
        // {
        //     efNewsLetterRepository = new EfNewsLetterRepository();
        // }

        public EfNewsLetterRepository(DataContext context) : base(context)
        {
            //  _context = context;
        }
    }
}