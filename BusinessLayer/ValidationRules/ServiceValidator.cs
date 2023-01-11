using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ServiceValidator : AbstractValidator<Service>
    {
        public ServiceValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Lütfen Hizmet başlığı giriniz");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Hizmet  en az 5 karakter olmalıdır");
            RuleFor(x => x.ImageUrl).NotNull().WithMessage("Hizmet Resmi boş geçilemez.");
        }
    }
}
