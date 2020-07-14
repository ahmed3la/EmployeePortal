using System;
using System.Collections.Generic;
using System.Text;
using static EmployeePortal.Services.Factory.AbstractFactory.Enumeration;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class MAC : IBrands
    {
        public string GetBrand()
        {
            return Brands.Apple.ToString();
        }
    }
}
