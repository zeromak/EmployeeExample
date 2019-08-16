using MasGlobal.Core.DTO;
using MasGlobal.Core.Interfaces;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace MasGlobal.Core.Factories
{
    public static class EmployeeFactory
    {
        /// <summary>
        /// Creates a list of employees from a json string
        /// </summary>
        /// <param name="jsonEmployees">Json containing an array of employees</param>
        /// <returns>List of employees</returns>
        public static IEnumerable<Employee> CreateEmployees(string jsonEmployees)
        {
            List<Employee> lstEmployees = new List<Employee>();
            JArray arrEmployees = JArray.Parse(jsonEmployees);

            foreach (dynamic objEmployee in arrEmployees.Children())
            {
                if (objEmployee.contractTypeName.Value.Equals("HourlySalaryEmployee"))
                    lstEmployees.Add(new HourlySalaryEmployeeDTO(objEmployee));
                else
                    lstEmployees.Add(new MonthlySalaryEmployeeDTO(objEmployee));
            }            
            return lstEmployees;
        }
    }
}
