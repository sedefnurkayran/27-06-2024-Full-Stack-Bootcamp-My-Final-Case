using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Abstract
{

    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void TUpdate(T t);
        List<T> GetList();
        T GetById(int id);

    }
}