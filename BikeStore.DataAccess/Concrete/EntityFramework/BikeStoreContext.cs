﻿using BikeStore.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MySqlConnector;

namespace BikeStore.DataAccess.Concrete.EntityFramework
{
    public class BikeStoreContext : DbContext
    {

        //Connection-String
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SAM0GTS\LOCAL2; Database=BikeStores; Trusted_Connection=True");
            
        }



        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Stock> Stocks { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Store> Stores { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<Photo> Photos { get; set; }
      


    }
}
