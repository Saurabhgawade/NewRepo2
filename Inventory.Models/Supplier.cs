using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Models
{
    public class Supplier
    {
        [Required]
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public string City { get; set; }
        public  int PinCode { get; set; }
        public int Contact { get; set; }
    }
}
