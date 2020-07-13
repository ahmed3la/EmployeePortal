using EmployeePortal.Core;
using EmployeePortal.Services.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.FactoryMethod
{
    class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {

        }
        public override IEmployeeManager Create()
        {
            ContractEmployeeManager manager = new ContractEmployeeManager();
            _emp.MedicalAllowance = manager.GetMedicalAllowance();

            return manager;
        }
    }
}
