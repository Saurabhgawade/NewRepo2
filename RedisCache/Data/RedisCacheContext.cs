using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RedisCache.Models;

namespace RedisCache.Data
{
    public class RedisCacheContext : DbContext
    {
        public RedisCacheContext (DbContextOptions<RedisCacheContext> options)
            : base(options)
        {
        }

        public DbSet<RedisCache.Models.Company> Company { get; set; } = default!;
    }
}
