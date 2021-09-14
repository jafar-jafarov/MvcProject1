using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
   public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazicinin adini bos buraxa bilmezsiniz!!!");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Yazicinin soyadini bos buraxa bilmezsinizz!!");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Haqqinda hissesini bos buraxa bilmezsinizz!!");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Unvan hissesini bos buraxa bilmezsinizz!!");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("Zehmet olmasa en azi 3 simvol daxil edin");
            RuleFor(x => x.WriterSurName).MaximumLength(20).WithMessage("Zehmet olmsa 20 simvoldan cox daxil etmeyin");
        }
    }
}
