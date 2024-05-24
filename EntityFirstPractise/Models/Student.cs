using System.ComponentModel.DataAnnotations;

namespace EntityFirstPractise.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
    }
}
