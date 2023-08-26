using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Personel_Management.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personel_Management.Repository.Configurations
{
    internal class EmployeeHourConfiguration : IEntityTypeConfiguration<EmployeeHour>
    {
        public void Configure(EntityTypeBuilder<EmployeeHour> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.Start).IsRequired();
            builder.Property(x => x.End).IsRequired();



        }
    }
}
