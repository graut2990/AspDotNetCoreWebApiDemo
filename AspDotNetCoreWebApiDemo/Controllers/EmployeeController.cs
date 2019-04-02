using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspDotNetCoreWebApiDemo.Controllers
{ 
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
         private IEmployeeRespository _employeeRespository;      
        public EmployeeController(IEmployeeRespository employeeRespository)
        {
            _employeeRespository = employeeRespository;           
        }

          // GET api/Employee
        [HttpGet]
        public IEnumerable<Employee> GetEmployee()
        {
            return _employeeRespository.GetEmployee();
        }

        // GET api/Employee/1
        [HttpGet("{id}")]
        public Employee GetEmployee(int id)
        {
            return _employeeRespository.GetEmployee(id);
        }

        
       
    }
}
