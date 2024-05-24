using System.ComponentModel.DataAnnotations;

namespace CookiPractise.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Sirname { get; set; }
    }
}
