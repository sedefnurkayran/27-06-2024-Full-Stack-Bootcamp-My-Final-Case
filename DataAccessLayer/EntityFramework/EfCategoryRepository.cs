using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{

    public class EfCategoryRepository : GenericRepository<Category>, ICategoryDal
    {

        private Context _context;

        public EfCategoryRepository(Context context) : base(context)
        {
            _context = context;
        }
    }
}