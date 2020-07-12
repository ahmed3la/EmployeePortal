using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Services.Managers
{
    public interface IEmployeeManager
    {
        public decimal GetBouns();
        public decimal GetHourlyPay();
    }
}
