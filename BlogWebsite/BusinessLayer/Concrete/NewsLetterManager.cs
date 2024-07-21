using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {
        INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;

        }
        public void AddNewsLetter(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);

        }
    }
}