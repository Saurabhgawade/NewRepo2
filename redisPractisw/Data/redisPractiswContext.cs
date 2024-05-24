using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using redisPractisw.Models;

namespace redisPractisw.Data
{
    public class redisPractiswContext : DbContext
    {
        public redisPractiswContext (DbContextOptions<redisPractiswContext> options)
            : base(options)
        {
        }

        public DbSet<redisPractisw.Models.Student> Student { get; set; } = default!;
    }
}
