using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{

    public interface INewsLetterService : IGenericService<NewsLetter>
    {
        void AddNewsLetter(NewsLetter newsLetter);

    }
}
