using System.ComponentModel.DataAnnotations;

namespace MVC_Product.Models
{
    public class Product
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string ProductName { get; set; }

        [Required]
        public int ProductPrice { get; set; }
    }
}
