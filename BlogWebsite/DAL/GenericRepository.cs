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
            _context.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAllList()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            // return  _context.Set<T>().Find(id);
            var getId = _context.Set<T>().Find(id);
            if (getId == null)
            {
                throw new Exception("Not found");

            }
            return getId;

        }

        public void Insert(T t)
        {
            _context.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.Update(t);
            _context.SaveChanges();
        }
    }
}