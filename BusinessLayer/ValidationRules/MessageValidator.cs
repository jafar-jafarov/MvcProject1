using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class MessageValidator:AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alici adini bos buraxa bilmezsiniz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Movzunu bos buraxa bilmezsiniz");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("Mesaji bos buraxa bilmezsiniz");
            RuleFor(x => x.Subject).MinimumLength(3).WithMessage("Zehmet olmasa en azi 3 simvol daxil edin");
            RuleFor(x => x.Subject).MaximumLength(100).WithMessage("Zehmet olmsa 100 simvoldan cox daxil etmeyin");
        }
    }
}
