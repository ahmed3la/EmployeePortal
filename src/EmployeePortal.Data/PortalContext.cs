using EmployeePortal.Core;
using EmployeePortal.Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using System;
using System.Security.Cryptography;
 

namespace EmployeePortal.Data
{
    public class PortalContext:DbContext
    {
        public PortalContext(DbContextOptions<PortalContext> options )
            : base(options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new EmployeeTypeConfiguration());
             
           
        }
 

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeType> EmployeeTypes { get; set; }
    }
}
