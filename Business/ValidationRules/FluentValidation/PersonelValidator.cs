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
    public class PersonelValidator : AbstractValidator<Personel>
    {
        //Her tablo için ayrı class oluşturulur ve bu class AbstractValidator sınıfından türetilir.
        public PersonelValidator()
        {
            RuleFor(p => p.ad).NotEmpty().WithMessage(Messages.PersonelNameIsNotEmpty); //Buraya alt alta kuralları yazıyoruz.
        }
    }
}
