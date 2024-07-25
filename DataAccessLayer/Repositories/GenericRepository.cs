using System.Linq.Expressions;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private Context _context;
        public GenericRepository(Context context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            // using var c = new Context();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAllList()
        {
            // using var c = new Context();
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            // return  _context.Set<T>().Find(id);
            //using var c = new Context();
            var getId = _context.Set<T>().Find(id);
            if (getId == null)
            {
                throw new Exception("Not found");
            }
            return getId;

        }

        public void Insert(T t)
        {
            //using var c = new Context();
            _context.Add(t);
            _context.SaveChanges();
        }

        public List<T> GetAllList(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            //using var c = new Context();
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}