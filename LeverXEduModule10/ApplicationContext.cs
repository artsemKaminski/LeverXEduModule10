using Microsoft.EntityFrameworkCore;

namespace LeverXEduModule10
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=LeverXEduModule10;Trusted_Connection=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(b => b.Age)
                .HasColumnName("Age_changed_name");

            modelBuilder.Entity<User>().HasData(new User { Id = 1, Name = "Artsem", Age = 36 });

        }
    }
}
