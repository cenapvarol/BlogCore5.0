using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent{ get; set; }
        public string BlogThumbnailImage{ get; set; }
        public string BlogImage { get; set; }
        public DateTime BlogCreateDate{ get; set; }
        public bool BlogStatus { get; set; }
        //Burada ise ilişki oluşturma işleminin ikinci bacağı  aynı şekilde prop oluşturuyoruz prop lar ikitane olacak şekilde oluşturuluyor 
        //1. prop yani properti ID tutulacağı alan olacak
        //2.prop yani properti ilişki kurulacak class tanımlanması gerekiyor.

        //Burda ID oluştururken önemli olan kısım hangi class ilşe ilişki kurulacak ise o class Id adıyla birebir aynı isimde olmalı  category class ile ilşki kuracağımızdan category
        //ID yazacağız
        public int CategoryID { get; set; }

        //İlişki kurulacak class yani(table) yazılıyor.
        public Category Category { get; set; }


        public int WriteID { get; set; }

        //İlişki kurulacak class yani(table) yazılıyor.
        public Writer Writer { get; set; }

        //Burada ise yorumlar class ile ilişki kurulacak  bire çok ilişki olacak şekilde ayarlanacak 


        //Farklı Taplolarda ilişki kurmak işlemi için yapılması gereken adımlar  oncelikler  prop komutunu kullanara properti oluşturuyoruz.
        //

        //Buarada List türünde oluşturuyoruz istersek Icollection türündende  oluşturabiliriz.

        //"ICollection" bir interface iken "List" ise bir class tır. "ICollection", aralarında "List" de bulunan ve "ICollection" interfaceini
        //implemente eden herhangi bir classı veya bu classlardan türetilen herhangi bir classı alabilirken,
        //"List" sadece kendini ve List den türetilen sınıfları kabul eder.
        public List<Comment> Comments { get; set; }

    }
}
