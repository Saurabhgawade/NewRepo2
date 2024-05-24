using System.ComponentModel.DataAnnotations;

namespace RedisCache.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Designnation { get; set; }
    }
}
