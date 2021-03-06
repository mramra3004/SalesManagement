﻿using System;
using System.IO;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SalesManagement.ConsoleApp.Domain.Data.EF.Configurations;
using SalesManagement.ConsoleApp.Domain.Data.EF.Extensions;
using SalesManagement.ConsoleApp.Domain.Data.Entities;
using SalesManagement.ConsoleApp.Domain.Data.Interfaces;

namespace SalesManagement.ConsoleApp.Domain.Data.EF
{
    public class AppDbContext:DbContext
    {
//        public AppDbContext(DbContextOptions options) : base(options)
//        {
//        }

        public DbSet<Color> Colors { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }
    
        public DbSet<ProductQuantity> ProductQuantities { get; set; }

        public DbSet<ProductTag> ProductTags { get; set; }

        public DbSet<Size> Sizes { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<WholePrice> WholePrices { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.AddConfiguration(new ProductTagConfiguration());
            modelBuilder.AddConfiguration(new TagConfiguration());
        }
        

        public override int SaveChanges()
        {
            var modified = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified || e.State == EntityState.Added);
            foreach (var item in modified)
            {
                var changedOrAddedItem = item.Entity as IDateTracking;
                if (changedOrAddedItem == null) continue;
                if (item.State == EntityState.Added)
                {
                    changedOrAddedItem.DateCreated = DateTime.Now;
                }
                changedOrAddedItem.DateModified = DateTime.Now;
            }

            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=DESKTOP-KNS39N1\SQLEXPRESS;Database=SalesManagement;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
//        public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
//        {
//            public AppDbContext CreateDbContext(string[] args)
//            {
//                IConfiguration configuration = new ConfigurationBuilder()
//                    .SetBasePath(Directory.GetCurrentDirectory())
//                    .AddJsonFile("appsettings.json").Build();
//                var builder = new DbContextOptionsBuilder<AppDbContext>();
//                var connectionString = configuration.GetConnectionString("DefaultConnection");
//                builder.UseSqlServer(connectionString);
//                return new AppDbContext(builder.Options);
//            }
//        }
    }
    
}