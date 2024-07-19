
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.DAL.EntityFramework
{
    public class EfContactRepository : GenericRepository<Contact>, IConctactDal
    {

        public EfContactRepository(DataContext context) : base(context)
        {
        }
    }
}