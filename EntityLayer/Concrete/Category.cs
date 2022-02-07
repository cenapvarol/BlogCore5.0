using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }

        //Farklı Taplolarda ilişki kurmak işlemi için yapılması gereken adımlar  oncelikler  prop komutunu kullanara properti oluşturuyoruz.
        //

        //Buarada List türünde oluşturuyoruz istersek Icollection türündende  oluşturabiliriz.

        //"ICollection" bir interface iken "List" ise bir class tır. "ICollection", aralarında "List" de bulunan ve "ICollection" interfaceini
        //implemente eden herhangi bir classı veya bu classlardan türetilen herhangi bir classı alabilirken,
        //"List" sadece kendini ve List den türetilen sınıfları kabul eder.
        public List<Blog> Blogs { get; set; }

    }
}
