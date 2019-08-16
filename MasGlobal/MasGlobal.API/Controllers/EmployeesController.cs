using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MasGlobal.Core.Interfaces;
using MasGlobal.ExternalServices;
using System.Linq;

namespace MasGlobal.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : Controller
    {
        // GET api/employees
        [HttpGet]
        public ActionResult<IEnumerable<Employee>> Get()
        {          
            return EmployeesService.GetAllEmployees().ToList();
        }

        // GET api/employees/{id}
        [HttpGet("{id}")]
        public ActionResult<Employee> Get(int id)
        {
            return EmployeesService.GetEmployee(id);            
        }
    }
}