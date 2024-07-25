using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{
  public class EfAboutRepository : GenericRepository<About>, IAboutDal
  {

    private Context _context;

    public EfAboutRepository(Context context) : base(context)
    {
      _context = context;
    }
  }
}