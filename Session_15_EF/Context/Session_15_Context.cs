using Microsoft.EntityFrameworkCore;
using Classes;

namespace Session_15_EF.Context {
    public class Session_15_Context : DbContext {

        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers{ get; set; }
        public DbSet<ProductCategory> ProductCategoriies { get; set; }
        public DbSet<TransactionLine> TransactionLines { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ConfigProduct()); //ftiaxnoume mia kainouria klassi configuration gia to Product kai tin kanoume apply
        }                                          // opote tin wra pou tha ftiaksei to montelo tha efarmosei oti exouome pei sto ConfigureationProduct

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);

            string connStr = @"Data Source=LAPTOP-97BN5M6S\\GEORGE;Initial Catalog = DbCoffeeBlue;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            optionsBuilder.UseSqlServer(connStr);
        }
    }
}
