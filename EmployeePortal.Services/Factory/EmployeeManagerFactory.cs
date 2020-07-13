using EmployeePortal.Services.Factory;
using EmployeePortal.Services.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Services.Factory
{
    public class EmployeeManagerFactory
    { 
        public IEmployeeManager GetEmployeeType(int employeeType)
        {
            IEmployeeManager returnValue = null;
            
            if (employeeType == 1)
                returnValue = new PermanentEmployeeManager();
            else if (employeeType == 2)
                returnValue = new ContractEmployeeManager();
            
            return returnValue;
        }
    }
}
