using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using entitycodefirstfinal.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace entitycodefirstfinal.Data
{
    public class entitycodefirstfinalContext : IdentityDbContext
    {
        public entitycodefirstfinalContext (DbContextOptions<entitycodefirstfinalContext> options)
            : base(options)
        {
        }

        public DbSet<entitycodefirstfinal.Models.Employee> Employee { get; set; } = default!;
    }
}
