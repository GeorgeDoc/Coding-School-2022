using Microsoft.EntityFrameworkCore;
using Classes;
using Session_15_EF.Configuration;

namespace Session_15_EF.Context {
    public class Session_15_Context : DbContext {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ConfigProduct());  // ftiaxnoume mia kainouria klassi configuration                                                           
            modelBuilder.ApplyConfiguration(new ConfigCustomer()); // gia to Product kai tin kanoume apply       
            modelBuilder.ApplyConfiguration(new ConfigEmployee()); // opote tin wra pou tha ftiaksei to montelo tha efarmosei 
            modelBuilder.ApplyConfiguration(new ConfigProductCategory());//oti exouome pei sto ConfigureationProduct
            modelBuilder.ApplyConfiguration(new ConfigTransLine());
            modelBuilder.ApplyConfiguration(new ConfigTransaction());
        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            string connStr = @"Data Source=LAPTOP-97BN5M6S\\GEORGE;Initial Catalog = DbCoffeeBlue;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
