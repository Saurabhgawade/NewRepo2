using System.ComponentModel.DataAnnotations;

namespace Cab_Management_System.Models
{
    public class Cab
    {
        [Required]
        [Key]
        public int CabId { get; set; }
        [Required]
        public  string From { get; set; }
        [Required]
        public string Too { get; set; }
        [Required]
        public int Amount { get; set; }

    }
}
