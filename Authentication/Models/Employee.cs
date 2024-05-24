using System.ComponentModel.DataAnnotations;

namespace Authentication.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSirName { get; set; }
    }
}
