using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.AbstractFactory
{
    public class I7 : IProcessors
    {
        public string GetProcessors()
        {
            return Enumeration.Processors.I7.ToString();
        }
    }

    public class I5 : IProcessors
    {
        public string GetProcessors()
        {
            return Enumeration.Processors.I5.ToString();
        }
    }

    public class I3 : IProcessors
    {
        public string GetProcessors()
        {
            return Enumeration.Processors.I3.ToString();
        }
    }


}
