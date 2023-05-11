using Microsoft.EntityFrameworkCore;
using System.Data.Sql;

namespace WinFormsApp3
{
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=LibraryDb;Integrated Security=True;";

        public DbSet<User> Users { get; set; }
        public DbSet<Sob> Sobs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(u => u.Sobs)
                .WithOne(b => b.User)
                .HasForeignKey(b => b.Id);
        }
    }
    internal class AppDB
    {
    }
}
