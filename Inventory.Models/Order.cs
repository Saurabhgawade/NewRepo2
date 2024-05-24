using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
        public Status status { get; set; }
        public OrderType orderType { get; set; }
    }
}

namespace Inventory.Models
{
    public enum Status
    {
        CheckOut,Failed,Shipped,Delivered,Returned,Cancelled,Paid,Complete
    }
}

namespace Inventory.Models
{
    public enum OrderType
    {
        PurchaseOrder,CustomerOrder
    }
}