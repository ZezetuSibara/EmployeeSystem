using System.ComponentModel.DataAnnotations;

namespace angularCRUDWebAPI2.Models
{
    public class Employees
    {
        [Key]  //Marks this as a primary key
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Department { get; set; }
        public string DateofJoining { get; set; }
    }
}