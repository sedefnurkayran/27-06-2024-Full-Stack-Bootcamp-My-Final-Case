
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {

        public EfAboutRepository(DataContext context) : base(context)
        {
        }
    }
}