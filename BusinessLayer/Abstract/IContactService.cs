using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        void AddContact(Contact contact);

    }
}