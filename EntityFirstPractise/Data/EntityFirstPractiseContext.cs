using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EntityFirstPractise.Models;

namespace EntityFirstPractise.Data
{
    public class EntityFirstPractiseContext : DbContext
    {
        public EntityFirstPractiseContext (DbContextOptions<EntityFirstPractiseContext> options)
            : base(options)
        {
        }

        public DbSet<EntityFirstPractise.Models.Student> Student { get; set; } = default!;
    }
}
