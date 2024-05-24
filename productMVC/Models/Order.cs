using System.ComponentModel.DataAnnotations;

namespace productMVC.Models
{
    public class Order
    {
        [Key]
        public int orderId { get; set; }
        public  string orderFrom { get; set; }

        public string orderTo { get; set; }

        public int price { get; set; }
    }
}
