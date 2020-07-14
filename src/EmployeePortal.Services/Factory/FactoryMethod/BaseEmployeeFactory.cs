using EmployeePortal.Core;
using EmployeePortal.Services.Manager;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeePortal.Services.Factory.FactoryMethod
{
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;
        public BaseEmployeeFactory( Employee employee)
        {
            _emp = employee;
        }

        public Employee ApplySalary()
        {
            IEmployeeManager manager = this.Create();

            _emp.HourlyPay = manager.GetHourlyPay();
            _emp.Bonus = manager.GetBouns();

            return _emp;
        }

        public abstract IEmployeeManager Create();
    }
}
