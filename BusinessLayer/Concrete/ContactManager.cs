using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IConctactDal _contactdal;

        public ContactManager(IConctactDal conctactDal)
        {
            _contactdal = conctactDal;

        }
        public void AddContact(Contact contact)
        {
            _contactdal.Insert(contact);

        }

        public Contact TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Contact t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Contact t)
        {
            throw new NotImplementedException();
        }
    }

}