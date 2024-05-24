namespace InventoryManagementSystem.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        ICollection<Product> products { get; set; }
    }
}
