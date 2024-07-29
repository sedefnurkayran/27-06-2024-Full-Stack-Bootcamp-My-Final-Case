using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
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

        public Comment TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return _commentDal.GetAllList(x => x.BlogId == id);
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }
    }
}