using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        //constructor
        IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {

            _aboutDal = aboutDal;
        }
        public List<About> GetList()
        {
            return _aboutDal.GetAllList();
        }
    }
}