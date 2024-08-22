using DBContextTest.Models;
using Microsoft.EntityFrameworkCore;
namespace DBContextTest.Data
{
    public class DbContextTest : DbContext
    {

        public DbContextTest(DbContextOptions<DbContextTest> options)
            : base(options)
        {

        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=DESKTOP-MA71DLJ;Database=your_database;Trusted_Connection=True;");
        //}
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Product>()
        //        .HasOne(p => p.Category)
        //        .WithMany(c => c.Products)
        //        .HasForeignKey(p => p.CategoryId);
        //}
    }
}
