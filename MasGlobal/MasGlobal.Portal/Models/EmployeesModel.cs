using MasGlobal.Core.Interfaces;
using System.Collections.Generic;

namespace MasGlobal.Portal.Models
{
    /// <summary>
    /// Model for the employees page
    /// </summary>
    public class EmployeesModel
    {
        public int? employeeID { get; set; }
        public IEnumerable<Employee> lstEmployees { get; set; }
    }
}
