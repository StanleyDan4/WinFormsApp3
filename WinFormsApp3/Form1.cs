using Microsoft.EntityFrameworkCore;
using System.Data.Sql;

namespace WinFormsApp3
{
    public partial class Form1 : Form
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


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}