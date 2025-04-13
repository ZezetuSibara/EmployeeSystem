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

    }

}
