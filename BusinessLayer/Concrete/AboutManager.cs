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
    public class AboutManager : IAboutService
    {
        //Generate contructor oluşturmadan önce Aşağıdaki gibi interface implement ediyoruz 

        IAboutDal _aboutDal;

        //Generate contructor oluşturmak için  yapılan işlem yukarıda bulunan   AboutManager  üstüne gelerek  ctrl .  ya basıyoruz karşımıza gelen ekranda Generate contructor basıyoruz.

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<About> GetAllAboutList()
        {
            return _aboutDal.GetListAll();
        }

        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public About GetByIdAbout(int id)
        {
            return _aboutDal.GetById(id);
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
