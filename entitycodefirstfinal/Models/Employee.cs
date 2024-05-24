using System.ComponentModel.DataAnnotations;

namespace entitycodefirstfinal.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SirName { get; set; }
        public int Age { get; set; }
    }
}
