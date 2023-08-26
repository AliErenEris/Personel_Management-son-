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
    internal class EmployeeHourSeed : IEntityTypeConfiguration<EmployeeHour>
    {
        public void Configure(EntityTypeBuilder<EmployeeHour> builder)
        {
            builder.HasData(
                           new EmployeeHour
                           {
                               Id = 1,
                               EmployeeId = 1,
                               CreatedDate = DateTime.Now,
                               Start = "08:00",
                               End = "14:00"
                           },
                           new EmployeeHour
                           {
                               Id = 2,
                               EmployeeId = 2,
                               CreatedDate = DateTime.Now,
                               Start = "08:00",
                               End = "17:00"
                           },
                           new EmployeeHour
                           {
                               Id = 3,
                               EmployeeId = 3,
                               CreatedDate = DateTime.Now,
                               Start = "09:00",
                               End = "18:00"
                           });
        }

        
    }
}
