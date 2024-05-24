using System.ComponentModel.DataAnnotations;

namespace cookieauthentication.Models
{
    public class Employee
    {
        [Key]
        public int Emp_Id{ get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
