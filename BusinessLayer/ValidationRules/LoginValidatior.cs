using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class LoginValidatior: AbstractValidator<Writer>
    {
        public LoginValidatior()
        {
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail adresi boş geçilemez");
            RuleFor(x => x.WriterMail).EmailAddress().WithMessage("Geçerili bir mail adresi giriniz.");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre boş geçilemez.");
            RuleFor(x => x.WriterPassword).Equal(x => x.WriterPassword).WithMessage("Şifreniz hatalı");

        }
    }
}
