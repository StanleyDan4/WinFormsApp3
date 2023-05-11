﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    
    public class AppDbContext : DbContext
    {
        private const string ConnectionString = "DataSource=(localdb)\\mssqllocaldb;Initial Catalog = LibraryDb; IntegratedSecurity = True;";
        public DbSet<User> Users { get; set; }
        public DbSet<Sob> Sobs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }
        protected override void OnModelCreating(ModelBuilder
       modelBuilder)
        {
            modelBuilder.Entity<User>()
            .HasMany(u => u.Sobs)
            .WithOne(b => b.User)
            .HasForeignKey(b => b.Id);
        }

        internal class AppDb
        {
        }
    }
}
