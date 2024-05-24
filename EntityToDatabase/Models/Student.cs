using System.ComponentModel.DataAnnotations;

namespace EntityToDatabase.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string SirName { get; set; }
        
    }
}
