﻿using Microsoft.EntityFrameworkCore;

namespace LeverXEduModule10
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=LeverXEduModule10;Trusted_Connection=True;");
        }
    }
}
