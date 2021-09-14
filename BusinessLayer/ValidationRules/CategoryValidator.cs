using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRoles
{
   public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kateqoriya adini bos buraxa bilmezsiniz!!");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Aciqlamani bos buraxa bilmezsiniz!!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Zehmet olmasa en azi 3 simvol daxil edin");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Zehmet olmsa 20 simvoldan cox daxil etmeyin");

        }
    }
}
