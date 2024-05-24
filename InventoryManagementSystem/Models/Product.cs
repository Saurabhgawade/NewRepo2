using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Category category { get; set; }
        public Order order { get; set; }
    }
}
