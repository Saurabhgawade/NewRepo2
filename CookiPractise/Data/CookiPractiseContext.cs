using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookiPractise.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CookiPractise.Data
{
    public class CookiPractiseContext : IdentityDbContext
    {
        public CookiPractiseContext (DbContextOptions<CookiPractiseContext> options)
            : base(options)
        {
        }

        public DbSet<CookiPractise.Models.Employee> Employee { get; set; } = default!;
    }
}
