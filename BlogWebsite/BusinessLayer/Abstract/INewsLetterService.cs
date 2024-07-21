using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Abstract
{
    public interface INewsLetterService
    {
        void AddNewsLetter(NewsLetter newsLetter);

    }
}