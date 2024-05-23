using GeekShopping.ProductApi.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Model.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext() { }

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        //Entitys add
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 4,
                    Name = "Camisa",
                    Price = new decimal(10.00),
                    Description = "Camisa polo",
                    CategoryName = "Camisa",
                    ImageUrl = "https://marknetloja.s3.amazonaws.com/loja.laportt.com.br/0/0/4/4521.m.jpg"
                }
            );
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 5,
                  Name = "Camisa",
                  Price = new decimal(10.00),
                  Description = "Camisa polo",
                  CategoryName = "Camisa",
                  ImageUrl = "https://marknetloja.s3.amazonaws.com/loja.laportt.com.br/0/0/4/4521.m.jpg"
              }
          );
            modelBuilder.Entity<Product>().HasData(
              new Product
              {
                  Id = 6,
                  Name = "Camisa",
                  Price = new decimal(10.00),
                  Description = "Camisa polo",
                  CategoryName = "Camisa",
                  ImageUrl = "https://marknetloja.s3.amazonaws.com/loja.laportt.com.br/0/0/4/4521.m.jpg"
              }
          );

        }
    }
}
