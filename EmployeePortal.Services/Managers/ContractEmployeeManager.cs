using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Services.Managers
{
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBouns()
        {
            return 5;
        }

        public decimal GetHourlyPay()
        {
            return 12;
        }
        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}
