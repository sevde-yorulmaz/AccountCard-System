using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class UserValidator : AbstractValidator<AppUser>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Adınızı boş geçemezsiniz");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadınızı boş geçemezsiniz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adını boş geçemezsiniz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email adresinizi boş geçemezsiniz");
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon numarasını  boş geçemezsiniz");
        }
    }
}
