using System.Linq.Expressions;
using BlogWebsite.DAL.Abstract;

namespace BlogWebsite.DAL
{

    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        private DataContext _context;
        public GenericRepository(DataContext context)
        {
            _context = context;
        }

        public void Delete(T t)
        {
            //using var _context = new Context();
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAllList()
        {
            // using var _context = new Context();
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            // return  _context.Set<T>().Find(id);
            //using var _context = new Context();
            var getId = _context.Set<T>().Find(id);
            if (getId == null)
            {
                throw new Exception("Not found");

            }
            return getId;

        }

        public void Insert(T t)
        {
            //using var _context = new Context();
            _context.Add(t);
            _context.SaveChanges();
        }

        public List<T> GetAllList(Expression<Func<T, bool>> filter)
        {
            return _context.Set<T>().Where(filter).ToList();
        }

        public void Update(T t)
        {
            //using var _context = new Context();
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}