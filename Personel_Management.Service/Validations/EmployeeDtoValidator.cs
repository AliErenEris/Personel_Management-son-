using FluentValidation;
using Personel_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Service.Validations
{
    public class EmployeeDtoValidator : AbstractValidator<Employee>
    {
        public EmployeeDtoValidator()
        {
            RuleFor(x => x.UserName).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.Department).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleFor(x => x.DepartmentId).GreaterThan(1).WithMessage("Unvalid Department");
        }
    }
}
