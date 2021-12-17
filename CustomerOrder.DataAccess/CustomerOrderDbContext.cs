using CustomerOrder.Entities;
using Microsoft.EntityFrameworkCore;

namespace CustomerOrder.DataAccess
{
    class CustomerOrderDbContext : DbContext
    {
        public CustomerOrderDbContext()
        {

        }
        public CustomerOrderDbContext(DbContextOptions<CustomerOrderDbContext> options) : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server = . ;Initial Catalog = CustomerOrdersDb; Integrated Security = SSPI");
        }
        public DbSet<CustomerOrders> Orders { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Products> Products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerOrders>()
                .HasOne(i => i.Customer)
                .WithMany(i => i.CustomerOrders)
                .HasForeignKey(i => i.CustId)
                .HasPrincipalKey(i => i.CustomerId);
            modelBuilder.Entity<CustomerOrders>()
                .HasOne(i => i.Product)
                .WithMany(i => i.CustomerOrders)
                .HasForeignKey(i => i.ProId)
                .HasPrincipalKey(i => i.ProductId);           
        }

    }
}
