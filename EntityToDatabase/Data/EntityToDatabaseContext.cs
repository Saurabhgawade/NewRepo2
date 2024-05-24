using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityToDatabase.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace EntityToDatabase.Data
{
    public class EntityToDatabaseContext : IdentityDbContext
    {
        public EntityToDatabaseContext (DbContextOptions<EntityToDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<EntityToDatabase.Models.Student> Student { get; set; } = default!;
    }
}
