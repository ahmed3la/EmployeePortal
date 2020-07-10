using EmployeePortal.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Data.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();

            builder.HasOne(a => a.EmployeeType)
                .WithMany(a => a.Employees)
                .IsRequired(); 
            
        }





    }
}
