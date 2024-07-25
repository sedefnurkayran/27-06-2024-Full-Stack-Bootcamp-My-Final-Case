using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{

    public interface ICommentService : IGenericService<Comment>
    {
        void AddComment(Comment comment);
        //  void DeleteCategory(Category category);
        // void UpdateCategory(Category category);
        List<Comment> GetList(int id);
        //Comment GetById(int id);

    }
}
