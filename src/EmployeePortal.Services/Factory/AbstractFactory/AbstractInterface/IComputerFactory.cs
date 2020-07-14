using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public interface IComputerFactory
    {
        IProcessors Processors();
        IBrands Brands();
        ISystemType SystemType();
    }
}
