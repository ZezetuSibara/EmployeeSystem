using angularCRUDWebAPI2.Models;
using angularCRUDWebAPI2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace angularCRUDWebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeservice;
        public EmployeeController(EmployeeService employeeService) 
        {
            _employeeservice = employeeService;
        }
        [HttpGet]
        public IActionResult GetEmployees() {
            var Employees = _employeeservice.GetEmployees();
            return Ok(Employees);
        }
        [HttpPost]
        public IActionResult addEmployees([FromBody] Employees employees)
        {
            _employeeservice.AddEmployees(employees);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteEmployees(int id)
        {
            var deleteStatus = _employeeservice.DeleteEmployees(id);
            return Ok(deleteStatus);
        }
        [HttpPut("{id}")]
        public IActionResult updateEmployees(int id, [FromBody] Employees Employees)
        {
            var updateStatus = _employeeservice.UpdateEmployees(id, Employees);
            return Ok(updateStatus);
        }
    }

}
