using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface ICommentService
    {
        void CommentAdd(Comment comment);
        //void BlogDelete(Comment comment);
        //void BlogUpdate(Comment comment);
        //Comment  GetById(int id);
        List<Comment> GetAll(int id);
    }
}
