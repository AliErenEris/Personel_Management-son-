using Personel_Management.Core.Entities;
using Personel_Management.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Repository.Repositories
{
    public class EmployeeHourRepository : GenericRepository<EmployeeHour>, IEmployeeHourRepository
    {
        public EmployeeHourRepository(AppDbContext context) : base(context)
        {
            
        }
    }
}
