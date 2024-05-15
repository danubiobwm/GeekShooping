using GeekShopping.ProductApi.Model.Entity;
using Microsoft.EntityFrameworkCore;

namespace GeekShopping.ProductApi.Model.Context
{
    public class MySQLContext: DbContext
    {
        public MySQLContext(){}

        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        //Entitys add
        public DbSet<Product> Products { get; set; }

    }
}
