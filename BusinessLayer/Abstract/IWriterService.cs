using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{

    public interface IWriterService : IGenericService<Writer>
    {
        void AddWriter(Writer writer);
        //  void DeleteCategory(Category category);
        // void UpdateCategory(Category category);
        //  List<User> GetList(int id);
        //Comment GetById(int id);

    }
}