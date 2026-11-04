using Assignment_11._3.Model;
using Microsoft.EntityFrameworkCore;

namespace Assignment_11._3.Data
{
    public class FoodContext : DbContext
    {
        public DbSet<Food> Foods { get; set; }

        public FoodContext(DbContextOptions<FoodContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Food>().HasData( 
                new Food { Id = 1, Quantity = 0, Name = "Empty", Department = "None", TimeCreate = new DateOnly(2026,11,01)}
            );
        }

    }
}
