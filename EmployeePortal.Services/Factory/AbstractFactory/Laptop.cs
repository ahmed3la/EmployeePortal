using System;
using System.Collections.Generic;
using System.Text;
using static EmployeePortal.Services.Factory.AbstractFactory.Enumeration;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class Laptop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Laptop.ToString();
        }
    }

    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return ComputerType.Desktop.ToString();
        }
    }
}
