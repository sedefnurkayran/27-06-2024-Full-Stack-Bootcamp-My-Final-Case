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

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetList()
        {
            return _aboutDal.GetAllList();
        }

        public void TAdd(About t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(About t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(About t)
        {
            throw new NotImplementedException();
        }
    }
}