using angularCRUDWebAPI2.Models;
using angularCRUDWebAPI2.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace angularCRUDWebAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly DepartmentService _departmentService;
        public DepartmentController(DepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public IActionResult getDepartments() {
            var Departments = _departmentService.GetDepartments();
            return Ok(Departments);
        }
        [HttpPost]
        public IActionResult addDepartment([FromBody] Departments department) {
            _departmentService.AddDepartment(department);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult deleteDepatment(int id) {
            var deleteStatus = _departmentService.DeleteDepartment(id); 
            return Ok(deleteStatus);
        }
        [HttpPut("{id}")]
        public IActionResult updateDepartment(int id, [FromBody] Departments Department) {
            var updateStatus = _departmentService.UpdateDepartment(id, Department);
            return Ok(updateStatus);
        }
    }
}
