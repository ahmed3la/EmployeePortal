using EmployeePortal.Services.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory computerFactory;
        public EmployeeSystemManager(IComputerFactory _computerFactory)
        {
            computerFactory = _computerFactory;
        }

        public string GetSystemDetails()
        {
            IBrands brands = computerFactory.Brands();
            IProcessors processors = computerFactory.Processors();
            ISystemType systemType = computerFactory.SystemType();

            string returnValue = string.Format("{0} {1} {2}",
                brands.GetBrand(),
                processors.GetProcessors(),
                systemType.GetSystemType()
                );

            return returnValue;
        }
    }
}
