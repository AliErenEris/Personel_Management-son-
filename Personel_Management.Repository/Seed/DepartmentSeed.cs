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
    internal class DepartmentSeed : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasData(
               new Department { Id = 1, Name = "IT", CreatedDate = DateTime.Now, },
               new Department { Id = 2, Name = "HR", CreatedDate = DateTime.Now, },
               new Department { Id = 3, Name = "Management", CreatedDate = DateTime.Now, });
        }
    }
}
