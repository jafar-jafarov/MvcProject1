using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.UserMail).NotEmpty().WithMessage("Email hissesini bos buraxa bilmezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Movzu adini bos buraxa bilmezsiniz!!");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Istfadeci adini bos buraxa bilmezsiniz!!");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Zehmet olmasa en azi 3 simvol daxil edin");
            RuleFor(x => x.UserName).MinimumLength(3).WithMessage("Zehmet olmasa en azi 3 simvol daxil edin");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Zehmet olmsa 50 simvoldan cox daxil etmeyin");
        }
    }
}
