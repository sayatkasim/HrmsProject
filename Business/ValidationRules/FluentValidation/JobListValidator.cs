using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class JobListValidator : AbstractValidator<JobList>
    {
        public JobListValidator()
        {
            RuleFor(j => j.JobListName).NotEmpty();
            RuleFor(j => j.JobListName).MinimumLength(3).WithMessage("Meslek adı uzunluğu en az 3 karakter olmalı");
            //RuleFor(j => j.JobListName).Must(StartWithA).WithMessage("Meslek A Harfi ile Başlamıyor");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
