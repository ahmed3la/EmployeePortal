using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePortal.Services.Manager
{
    public interface IEmployeeManager
    {
        public decimal GetBouns();
        public decimal GetHourlyPay();
    }
}
