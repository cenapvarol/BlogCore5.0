using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentDate { get; set; }
        public bool commentStatus { get; set; }

        //Burada ise ilişki oluşturma işleminin ikinci bacağı  aynı şekilde prop oluşturuyoruz prop lar ikitane olacak şekilde oluşturuluyor 
        //1. prop yani properti ID tutulacağı alan olacak
        //2.prop yani properti ilişki kurulacak class tanımlanması gerekiyor.

        //Burda ID oluştururken önemli olan kısım hangi class ilşe ilişki kurulacak ise o class Id adıyla birebir aynı isimde olmalı  Blog class ile ilşki kuracağımızdan Blog
        //ID yazacağız

        //1. Aşama 
        public int BlogID { get; set; }

        //2. Aşama
        public Blog Blog { get; set; }
    }
}
