using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using productMVC.Models;

namespace productMVC.Data
{
    public class productMVCContext : DbContext
    {
        public productMVCContext (DbContextOptions<productMVCContext> options)
            : base(options)
        {
        }

        public DbSet<productMVC.Models.Order> Order { get; set; } = default!;
    }
}
