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
    public class ContactManager : IContactService
    {
        //Generate contructor oluşturmadan önce Aşağıdaki gibi interface implement ediyoruz 

        IContactDal _contactDal;

        //Generate contructor oluşturmak için  yapılan işlem yukarıda bulunan   ContacManager  üstüne gelerek  ctrl .  ya basıyoruz karşımıza gelen ekranda Generate contructor basıyoruz.

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void ContactAdd(Contact contact)
        {
            _contactDal.Insert(contact);
        }
    }
}
