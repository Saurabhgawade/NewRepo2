using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CatgoryName { get; set; }
        ICollection<Product> products { get; set; }
    }
}
