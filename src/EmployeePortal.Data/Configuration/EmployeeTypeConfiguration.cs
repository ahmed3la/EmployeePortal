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
    public class EmployeeTypeConfiguration : IEntityTypeConfiguration<EmployeeType>
    {
        public void Configure(EntityTypeBuilder<EmployeeType> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Id).UseIdentityColumn();
            


        }
    }
}
