using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class MACFactory : IComputerFactory
    {
        public IBrands Brands()
        {
            return new MAC();
        }

        public IProcessors Processors()
        {
            return new Processors();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class MACLaptopFactory : MACFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}
