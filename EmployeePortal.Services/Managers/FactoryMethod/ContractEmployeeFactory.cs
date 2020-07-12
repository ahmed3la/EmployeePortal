using EmployeePortal.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Managers.FactoryMethod
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
