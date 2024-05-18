using Business.Constans;
using Entities.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class KullaniciValidator : AbstractValidator<Kullanici>
    {
        public KullaniciValidator()
        {
            RuleFor(k => k.kullaniciAd).NotNull().WithMessage(Messages.KullaniciIsTooShort);
            RuleFor(h => h.kullaniciAd).NotEmpty();
            RuleFor(h => h.kullaniciAd).MinimumLength(3);
            RuleFor(k => k.passwordSalt).NotEmpty().WithMessage(Messages.KullaniciPasswordNotNull);
        }
    }
}
