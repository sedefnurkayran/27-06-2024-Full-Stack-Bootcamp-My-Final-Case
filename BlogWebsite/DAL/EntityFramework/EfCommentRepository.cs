
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {


    }
}