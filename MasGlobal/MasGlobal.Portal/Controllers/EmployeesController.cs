using System.Collections.Generic;
using MasGlobal.Core.Interfaces;
using MasGlobal.ExternalServices;
using MasGlobal.Portal.Models;
using Microsoft.AspNetCore.Mvc;

namespace MasGlobal.Portal.Controllers
{
    public class EmployeesController : Controller
    {
        /// <summary>
        /// Employees page without employees information
        /// </summary>
        /// <returns>View for employees</returns>
        public IActionResult Employees()
        {
            return View(new EmployeesModel());
        }

        /// <summary>
        /// Employees page with information for desired employee/s
        /// </summary>
        /// <param name="model">Model with id for specific employee</param>
        /// <returns>View for employees</returns>
        public ActionResult GetEmployees(EmployeesModel model)
        {
            if (model.employeeID.HasValue)
            {
                List<Employee> employees = new List<Employee>();
                Employee objEmployee = EmployeesService.GetEmployee(model.employeeID.Value);
                if (objEmployee != null)
                    employees.Add(objEmployee);
                model.lstEmployees = employees;
            }
            else
                model.lstEmployees = EmployeesService.GetAllEmployees();
            return View("Employees",model);
        }
    }
}