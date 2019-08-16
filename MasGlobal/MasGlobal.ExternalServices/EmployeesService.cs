using MasGlobal.Core.Interfaces;
using System.Collections.Generic;
using System.Net.Http;
using MasGlobal.ExternalServices.Helpers;
using System.Net;
using System.Linq;
using MasGlobal.Core.Factories;

namespace MasGlobal.ExternalServices
{
    public static class EmployeesService
    {
        /// <summary>
        /// Get an employee by his id
        /// </summary>
        /// <param name="employeeId">Id of the employee</param>
        /// <returns>Employee information</returns>
        public static Employee GetEmployee(int employeeId)
        {
            IEnumerable<Employee> lstEmployees = CallService();
            return lstEmployees.Where(x => x.id == employeeId).FirstOrDefault();
        }

        /// <summary>
        /// Get a list of all the employees
        /// </summary>
        /// <returns>Listo of employees</returns>
        public static IEnumerable<Employee> GetAllEmployees()
        {
            return CallService();
        }

        /// <summary>
        /// Gets all the employees information from the external source
        /// </summary>
        /// <returns>List of employees</returns>
        private static IEnumerable<Employee> CallService()
        {
            HttpResponseMessage objHttpResponseMessage = RESTClient.GetHttpResponse("http://masglobaltestapi.azurewebsites.net/api/Employees");
            if (objHttpResponseMessage.StatusCode == HttpStatusCode.OK)
            {
                string jsonContent = objHttpResponseMessage.Content.ReadAsStringAsync().Result;
                return EmployeeFactory.CreateEmployees(jsonContent);
            }
            else
                return new List<Employee>();
        }
    }
}
