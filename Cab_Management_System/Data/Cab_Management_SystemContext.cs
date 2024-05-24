using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cab_Management_System.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Cab_Management_System.Data
{
    public class Cab_Management_SystemContext : IdentityDbContext
    {
        public Cab_Management_SystemContext (DbContextOptions<Cab_Management_SystemContext> options)
            : base(options)
        {
        }

        public DbSet<Cab_Management_System.Models.Cab> Cab { get; set; } = default!;
    }
}
