using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Services.Manager
{
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBouns()
        {
            return 10;
        }

        public decimal GetHourlyPay()
        {
            return 8;
        }

        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}
