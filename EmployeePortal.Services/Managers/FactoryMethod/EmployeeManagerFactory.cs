using EmployeePortal.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Managers.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;
            if (emp.EmployeeTypeId == 1)
                returnValue = new PermanentEmployeeFactory(emp);
            else if (emp.EmployeeTypeId == 2)
                returnValue = new ContractEmployeeFactory(emp);

            return returnValue;
        }

    }
}
