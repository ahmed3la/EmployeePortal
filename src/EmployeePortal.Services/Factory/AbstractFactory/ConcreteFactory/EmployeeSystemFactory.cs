using EmployeePortal.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee emp)
        {
            IComputerFactory returnValue = null;
            if (emp.EmployeeTypeId == 1)
            {
                if (emp.JobDescription == "Manager")
                {
                    returnValue = new MACLaptopFactory();
                }
                else
                {
                    returnValue = new MACFactory();
                }
            }
            else if (emp.EmployeeTypeId == 2)
            {
                if (emp.JobDescription == "Manager")
                {
                    returnValue = new DellLaptopFactory();
                }
                else
                {
                    returnValue = new DellFactory();
                }
            }

            return returnValue;
        }
    }
}
