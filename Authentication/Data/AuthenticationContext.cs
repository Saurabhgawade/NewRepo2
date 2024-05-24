using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Authentication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Authentication.Data
{
    public class AuthenticationContext : IdentityDbContext
    {
        public AuthenticationContext (DbContextOptions<AuthenticationContext> options)
            : base(options)
        {
        }

        public DbSet<Authentication.Models.Employee> Employee { get; set; } = default!;
    }
}
