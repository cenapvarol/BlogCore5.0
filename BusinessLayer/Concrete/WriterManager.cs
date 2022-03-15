using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        //Generate contructor oluşturmadan önce Aşağıdaki gibi interface implement ediyoruz 
        IWriterDal _writerdal;


        //Generate contructor oluşturmak için  yapılan işlem yukarıda bulunan   WriterManager  üstüne gelerek  ctrl .  ya basıyoruz karşımıza gelen ekranda Generate contructor basıyoruz.
        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public List<Writer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            return _writerdal.GetById(id);
        }

        public List<Writer> GetWriterById(int id)
        {
            return _writerdal.GetListAll(x => x.WriterID == id);
              
        }

        public void TAdd(Writer t)
        {
            _writerdal.Insert(t);
        }

        public void TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Writer t)
        {
            _writerdal.Update(t);
        }

        public void WriterDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void WriterUpdate(Writer writer)
        {
            throw new NotImplementedException();
        }
    }
}
