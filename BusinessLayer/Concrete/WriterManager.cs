using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{

    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;

        }

        public void AddWriter(Writer writer)
        {
            _writerDal.Insert(writer);
        }

        public Writer TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }

        public void TAdd(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}