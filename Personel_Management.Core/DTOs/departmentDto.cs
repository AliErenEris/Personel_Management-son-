using Personel_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Core.DTOs
{
    public class departmentDto
    {
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
