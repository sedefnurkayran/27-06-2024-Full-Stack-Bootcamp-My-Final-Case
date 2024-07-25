using EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using DataAccessLayer.Concrete;
namespace DataAccessLayer.EntityFramework
{
  public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
  {

    private Context _context;

    public EfCommentRepository(Context context) : base(context)
    {
      _context = context;
    }
  }
}