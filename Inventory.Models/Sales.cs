using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Sales
    {
        public int SaleId { get; set; }
        public string Name { get; set; }
        public DateTime SaleDate { get; set; }
        public int Amount { get; set; }
    }
}
