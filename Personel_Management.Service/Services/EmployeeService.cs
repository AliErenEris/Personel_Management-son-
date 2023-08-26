using Personel_Management.Core.Entities;
using Personel_Management.Core.Repositories;
using Personel_Management.Core.Service;
using Personel_Management.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Service.Services
{
    public class EmployeeService : GenericService<Employee>, IEmployeeService
    {
        public EmployeeService(IGenericRepository<Employee> repository, IUnitOfWork unitOfWork) : base(repository, unitOfWork)
        {
        }
    }
}
