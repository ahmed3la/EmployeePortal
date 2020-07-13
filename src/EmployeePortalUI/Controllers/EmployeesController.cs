using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmployeePortal.Core;
using EmployeePortal.Data;
using EmployeePortal.Data.Repository;
using System.Timers;
//using EmployeePortal.Services.Factory;
using EmployeePortal.Services.Factory.FactoryMethod;

namespace EmployeePortalUI.Controllers
{
    public class EmployeesController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public EmployeesController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        // GET: Employees
        public async Task<IActionResult> Index()
        {

            var x = await unitOfWork.Employees.GetAsync();
            return View(x);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await unitOfWork.Employees
                .GetAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
         
        // GET: Employees/Create
        public async Task<IActionResult> Create()
        {
            await FillSelectListEmployeeType();

            return View();
        }
        private async Task FillSelectListEmployeeType()
        {
            var employeeTypes = (await unitOfWork.EmployeeTypes.GetAsync()).ToList();

            employeeTypes.Insert(0, new EmployeeType() { Id = -1, EmpType = "--- Please select a type ---" });
            //return employeeTypes;

            ViewBag.EmpType = employeeTypes;
        }


        Employee CalcalteHourlyPay_Bonus(Employee employee)
        {
            BaseEmployeeFactory empFactory = new EmployeeManagerFactory().CreateFactory(employee);
            empFactory.ApplySalary();
            //IEmployeeManager empMager = empFactory.GetEmployeeType(employee.EmployeeTypeId);
            //employee.HourlyPay = empMager.GetHourlyPay();
            //employee.Bonus = empMager.GetBouns();
             
            return employee;
        }

        // POST: Employees/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( Employee employee)
        {
            if (ModelState.IsValid)
            {
                CalcalteHourlyPay_Bonus(employee);

                unitOfWork.Employees.Insert(employee);
                await unitOfWork.SaveAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await unitOfWork.Employees.FindAsync(id);
            if (employee == null)
            {
                return NotFound();
            }
            await FillSelectListEmployeeType();
            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,JobDescription,Number,Department,EmployeeTypeId")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    CalcalteHourlyPay_Bonus(employee);
                    unitOfWork.Employees.Update(employee);
                    await unitOfWork.SaveAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmployeeExists(employee.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var employee = await unitOfWork.Employees
                .GetAsync(m => m.Id == id);
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var employee = await unitOfWork.Employees.FindAsync(id);
            unitOfWork.Employees.Delete(employee);
            await unitOfWork.SaveAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmployeeExists(int id)
        {
            return unitOfWork.Employees.Any(e => e.Id == id);
        }
    }
}
