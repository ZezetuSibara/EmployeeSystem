using angularCRUDWebAPI2.Data;
using angularCRUDWebAPI2.Models;

namespace angularCRUDWebAPI2.Services
{
    public class DepartmentService
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Departments> GetDepartments() {
        var Departments = _appDbContext.departments.ToList();
            return Departments;
        }
        public void AddDepartment(Departments department) { 
            _appDbContext.departments.Add(department);
            _appDbContext.SaveChanges();
        }
        public bool DeleteDepartment(int id) {
            var department = _appDbContext.departments.Find(id);
            if (department != null) {
                _appDbContext.departments.Remove(department);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
