using Microsoft.EntityFrameworkCore;

namespace _01_08_나성식_airplane_reservation
{
    class Database : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Airplane> Airplanes { get; set; }
        public DbSet<Reserve> Reserves { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\mssqlLocalDB;" + "Initial Catalog=Airplane;" + "Integrated Security=true");
        }
    }
}
