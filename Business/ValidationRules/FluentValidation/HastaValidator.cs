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
    public class HastaValidator:AbstractValidator<Hasta>
    {
        public HastaValidator()
        {
            RuleFor(h => h.ad).NotEmpty();
            RuleFor(h => h.ad).NotNull();
            RuleFor(h => h.ad).MinimumLength(2);
        }
    }
}
