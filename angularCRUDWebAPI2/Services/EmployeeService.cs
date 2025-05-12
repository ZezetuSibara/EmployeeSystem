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
        public List<Employees> GetEmployees()
        {
            var Employees = _appDbContext.employees.ToList();
            return Employees;
        }
        public void AddEmployees(Employees employees)
        {
            _appDbContext.employees.Add(employees);
            _appDbContext.SaveChanges();
        }
        public bool DeleteEmployees(int id)
        {
            var employees = _appDbContext.employees.Find(id);
            if (employees != null)
            {
                _appDbContext.employees.Remove(employees);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateEmployees(int id, Employees employees)
        {
            var OldEmployee = _appDbContext.employees.Find(id);
            if (OldEmployee != null)
            {
                OldEmployee.EmployeeName = employees.EmployeeName;
                OldEmployee.Department = employees.Department;
                OldEmployee.DateofJoining = employees.DateofJoining;
                _appDbContext.employees.Update(OldEmployee);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

