using Microsoft.EntityFrameworkCore;

namespace MyDB
{
    class Northwind : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\mssqlLocalDB;" + "Initial Catalog=Northwind;" + "Integrated Security=true");
        }

    }
}
