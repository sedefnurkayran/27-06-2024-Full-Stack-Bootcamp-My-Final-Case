using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace BlogWebsite.BusinessLayer.Concrete
{

    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;

        }
        public void AddComment(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetAllList(x => x.BlogId == id);
        }
    }
}