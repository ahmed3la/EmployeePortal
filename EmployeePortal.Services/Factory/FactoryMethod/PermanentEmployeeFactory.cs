using EmployeePortal.Core;
using EmployeePortal.Services.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp):base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager manager = new PermanentEmployeeManager();
            _emp.HouseAllowance = manager.GetHouseAllowance();

            return manager;
        }
    }
}
