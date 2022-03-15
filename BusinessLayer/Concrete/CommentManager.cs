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
    public class CommentManager : ICommentService
    {

        //Generate contructor oluşturmadan önce Aşağıdaki gibi interface implement ediyoruz 

        ICommentDal _commentDal;

        //Generate contructor oluşturmak için  yapılan işlem yukarıda bulunan   CommentManager  üstüne gelerek  ctrl .  ya basıyoruz karşımıza gelen ekranda Generate contructor basıyoruz.

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public List<Comment> GetAll(int id)
        {
          return  _commentDal.GetListAll(x=>x.BlogID == id);
        }


    }
}
