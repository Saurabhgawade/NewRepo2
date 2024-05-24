using System.ComponentModel.DataAnnotations;

namespace EntityFramework.Models
{
    public class Student
    {
        [Key]
         public int Id { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
    }
}
