namespace BlogWebsite.DAL.Abstract
{

    public interface IGenericRepository<T> where T : class
    {

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> GetAllList();
        T GetById(int id);
    }
}