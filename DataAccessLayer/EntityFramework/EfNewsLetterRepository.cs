using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{


    public class EfNewsLetterRepository : GenericRepository<NewsLetter>, INewsLetterDal
    {
        private Context _context;

        public EfNewsLetterRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}