using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personel_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Repository.Seed
{
    internal class EmployeeSeed : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                new Employee
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    Name = "Ali",
                    Lastname = "Cabbar",
                    UserName = "cabbar45",
                    Password = "password",
                    Age = 20,
                    EmployeeHoursId = 1,
                    DepartmentId = 1,
                },
                new Employee
                {
                    Id = 2,
                    CreatedDate = DateTime.Now,
                    Name = "Mahmut",
                    Lastname = "Yıldırım",
                    UserName = "mahmut45",
                    Password = "password",
                    Age = 23,
                    EmployeeHoursId = 2,
                    DepartmentId = 2,
                },
                new Employee
                {
                    Id = 3,
                    CreatedDate = DateTime.Now,
                    Name = "Zeynep",
                    Lastname = "Alkan",
                    UserName = "alkan35",
                    Password = "password",
                    Age = 22,
                    EmployeeHoursId = 3,
                    DepartmentId = 2,
                });
        }
    }
}
