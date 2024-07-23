
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfWriterRepository : GenericRepository<Writer>, IWriterDal
    {

        public EfWriterRepository(DataContext context) : base(context)
        {
            //  _context = context;
        }

        // public void Delete(Writer t)
        // {
        //     throw new NotImplementedException();
        // }

        // public List<Writer> GetAllList(System.Linq.Expressions.Expression<Func<Writer, bool>> filter)
        // {
        //     throw new NotImplementedException();
        // }

        // public void Insert(Writer t)
        // {
        //     throw new NotImplementedException();
        // }

        // public void Update(Writer t)
        // {
        //     throw new NotImplementedException();
        // }

        // List<Writer> IGenericDal<Writer>.GetAllList()
        // {
        //     throw new NotImplementedException();
        // }

        // Writer IGenericDal<Writer>.GetById(int id)
        // {
        //     throw new NotImplementedException();
        // }
    }
}