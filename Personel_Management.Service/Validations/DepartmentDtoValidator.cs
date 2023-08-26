using Personel_Management.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Personel_Management.Service.Validations
{
    public class DepartmentDtoValidator : AbstractValidator<departmentDto>
    {
        public DepartmentDtoValidator()
        {
            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} is required").NotEmpty().WithMessage("{PropertyName} is required");
            RuleForEach(x => x.Employees).NotNull().WithMessage("{PropertyName} is required");
        }
    }
}
