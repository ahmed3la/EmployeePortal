using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class DellFactory : IComputerFactory
    {
        public IBrands Brands()
        {
            return new Dell();
        }

        public IProcessors Processors()
        {
            return new I5();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class DellLaptopFactory : DellFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
