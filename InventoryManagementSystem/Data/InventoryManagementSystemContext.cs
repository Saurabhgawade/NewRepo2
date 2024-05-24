using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Data
{
    public class InventoryManagementSystemContext : DbContext
    {
        public InventoryManagementSystemContext (DbContextOptions<InventoryManagementSystemContext> options)
            : base(options)
        {
        }

        public DbSet<InventoryManagementSystem.Models.Product> Product { get; set; } = default!;
    }
}
