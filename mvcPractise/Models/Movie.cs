using System.ComponentModel.DataAnnotations;

namespace mvcPractise.Models
{
    public class Movie
    {
        [Required]
        public int id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        public string Director { get; set; }
    }
}
