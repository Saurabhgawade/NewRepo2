using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cookieauthentication.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace cookieauthentication.Data
{
    public class cookieauthenticationContext : IdentityDbContext
    {
        public cookieauthenticationContext (DbContextOptions<cookieauthenticationContext> options)
            : base(options)
        {
        }

        public DbSet<cookieauthentication.Models.Employee> Employee { get; set; } = default!;
    }
}
