using System.ComponentModel.DataAnnotations;

namespace angularCRUDWebAPI2.Models
{
    public class Departments
    {
        [Key]  //Marks this a primary key
        public int Id { get; set; }
        public string DepartmentName { get; set; }
    }
}
