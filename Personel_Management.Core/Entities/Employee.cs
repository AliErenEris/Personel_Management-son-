using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Core.Entities
{
    public class Employee : BaseEntity
    {
        public string UserName { get; set; }
        public string  Password { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public int? EmployeeHoursId { get; set; }
        public EmployeeHour? EmployeeHours { get; set; }

        public int DepartmentId { get; set; }
        public Department Department  { get; set; }

    }
}
