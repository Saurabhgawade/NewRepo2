using Inventory.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Inventory.Repository
{
    public class InventoryContext:DbContext
    {
        public InventoryContext()
        {
            
        }

        public InventoryContext(DbContextOptions<InventoryContext> options) : base(options)
        {
        }







        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Sales> Sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Inventory1;trusted_connection=true");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasOne(p => p.category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Sales>()
                .HasOne(s => s.Order)
                .WithMany(o => o.Sales)
                .HasForeignKey(s => s.OrderId);

            modelBuilder.Entity<Product>()
                .HasOne(o => o.supplier)
                .WithMany(l => l.Products)
                .HasForeignKey(n => n.SupplierId);

            modelBuilder.Entity<Sales>()
                .HasOne(m => m.product)
                .WithMany(g => g.Sales)
                .HasForeignKey(h => h.ProductId);

            modelBuilder.Entity<Category>()
     .Property(c => c.CategoryId)
     .ValueGeneratedOnAdd();


        }
        
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        // Load connection string from appsettings.json
        //        IConfigurationRoot configuration = new ConfigurationBuilder()
        //            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
        //            .AddJsonFile("appsettings.json")
        //            .Build();


        //        // Use SQL Server provider with the connection string
        //        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConnectionString"));
        //    }
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    if (!optionsBuilder.IsConfigured)
        //    {
        //        if (!optionsBuilder.IsConfigured)
        //        {
        //            string Connection = "Server=(localdb)\\MSSQLLocalDB;Database=Inventory1;Trusted_Connection=True;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;Encrypt=True";
        //            optionsBuilder.UseSqlServer(Connection);
        //        }
        //    }

        //}


        //public IConfiguration Configuration { get; }
        //public void ConfigureServices(IServiceCollection services)
        //{
        //    services.AddDbContext<InventoryContext>(options =>
        //        options.UseSqlServer(Configuration.GetConnectionString("ConnectionString")));
    }
   



}

