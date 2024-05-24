using System.ComponentModel.DataAnnotations;

namespace productMVC.Models
{
    public class Product
    {
        [Range(1,1000)]
        public int productId { get; set; }

        [Required]
        public string productName { get; set; }

        [Required]
        public int productPrice { get; set; }
    }
}
