using angularCRUDWebAPI2.Data;
using angularCRUDWebAPI2.Models;
using System.Data;

namespace angularCRUDWebAPI2.Services
{
    public class DepartmentService
    {
        private readonly AppDbContext _appDbContext;
        public DepartmentService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public List<Departments> GetDepartments()
        {
            var Departments = _appDbContext.departments.ToList();
            return Departments;
        }
        public void AddDepartment(Departments department)
        {
            _appDbContext.departments.Add(department);
            _appDbContext.SaveChanges();
        }
        public bool DeleteDepartment(int id)
        {
            var department = _appDbContext.departments.Find(id);
            if (department != null)
            {
                _appDbContext.departments.Remove(department);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdateDepartment(int id, Departments department)
        {
            var OldDepartment = _appDbContext.departments.Find(id);
            if (OldDepartment != null)
            {
                OldDepartment.DepartmentName = department.DepartmentName;
                _appDbContext.departments.Update(OldDepartment);
                _appDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
