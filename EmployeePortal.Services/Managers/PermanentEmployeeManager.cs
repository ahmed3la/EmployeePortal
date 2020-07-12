using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Services.Managers
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
    }
}
