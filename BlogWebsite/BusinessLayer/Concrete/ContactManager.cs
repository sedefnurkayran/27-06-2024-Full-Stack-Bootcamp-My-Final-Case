using BlogWebsite.BusinessLayer.Abstract;
using BlogWebsite.DAL.Abstract;
using BlogWebsite.Models;

namespace BlogWebsite.BusinessLayer.Concrete
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
    }
}