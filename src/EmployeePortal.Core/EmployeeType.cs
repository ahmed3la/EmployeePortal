using System;
using System.Collections;
using System.Collections.Generic;

namespace EmployeePortal.Core
{
    public class EmployeeType
    {
        public int Id { get; set; }
        public string EmpType { get; set; }
        public ICollection<Employee>  Employees  { get; set; }

         
         
 
    }
}
