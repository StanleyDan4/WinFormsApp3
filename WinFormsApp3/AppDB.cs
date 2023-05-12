using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog = LibraryDb_my; Integrated Security = True;";
        public DbSet<User> Users { get; set; }
        public DbSet<Sob> Sobs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(b => b.Sobs)
            .WithOne(u => u.User)
            .HasForeignKey(b => b.Id);
        }

    }
}
