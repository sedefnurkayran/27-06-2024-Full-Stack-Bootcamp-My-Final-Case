using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{


  public class EfContactRepository : GenericRepository<Contact>, IConctactDal
  {

    private Context _context;

    public EfContactRepository(Context context) : base(context)
    {
      _context = context;
    }
  }
}