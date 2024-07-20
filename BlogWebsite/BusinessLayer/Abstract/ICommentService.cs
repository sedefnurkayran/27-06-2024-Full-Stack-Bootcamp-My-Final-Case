using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Abstract
{

    public interface ICommentService
    {
        void AddComment(Comment comment);
        //  void DeleteCategory(Category category);
        // void UpdateCategory(Category category);
        List<Comment> GetList(int id);
        //Comment GetById(int id);

    }
}