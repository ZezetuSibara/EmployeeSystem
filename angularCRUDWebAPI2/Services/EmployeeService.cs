using angularCRUDWebAPI2.Data;
using angularCRUDWebAPI2.Models;

namespace angularCRUDWebAPI2.Services
{
    public class EmployeeService
    {
        private readonly AppDbContext _appDbContext;
        public EmployeeService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Employees> GetEmployees() {
        var Employees = _appDbContext.employees.ToList();
            return Employees;
        }
    }
}
