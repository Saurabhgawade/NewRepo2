using System.ComponentModel.DataAnnotations;

namespace redisPractisw.Models
{
    public class Student
    {
        [Key]
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Subject{ get; set; }
        public int Mark { get; set; }
    }
}
