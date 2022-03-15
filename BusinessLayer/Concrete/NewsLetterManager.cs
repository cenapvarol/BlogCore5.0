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
    public class NewsLetterManager : INewsLetterService
    {
        //Generate contructor oluşturmadan önce Aşağıdaki gibi interface implement ediyoruz 

        INewsLetterDal _newsLetterDal;

        //Generate contructor oluşturmak için  yapılan işlem yukarıda bulunan   WriterManager  üstüne gelerek  ctrl .  ya basıyoruz karşımıza gelen ekranda Generate contructor basıyoruz.

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }

        public void addNewsLatter(NewsLetter newsLetter)
        {
            _newsLetterDal.Insert(newsLetter);
        }
    }
}
