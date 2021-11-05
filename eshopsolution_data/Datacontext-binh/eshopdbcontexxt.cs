using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshopsolution_data.entitys;
using Microsoft.EntityFrameworkCore;

namespace eshopsolution_data.Datacontext_binh
{
    public class eshopdbcontexxt:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-5G99QSN\\SQLEXPRESS;Initial Catalog=master;User ID=binh123;Password=123");
            }
        }

        public DbSet<product> Products { get; set; }
        public DbSet<AppConfig> AppConfig { get; set; }
        public DbSet<AppRole> AppRole { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
        public DbSet<Carts> Carts { get; set; }
        public DbSet<Categorycs> Categorycs { get; set; }
        public DbSet<CategoryTranslation> CategoryTranslation { get; set; }
        public DbSet<Contact> Contact { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<product> product { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<ProductInCategory> ProductInCategory { get; set; }
        public DbSet<ProductTranslation> ProductTranslation { get; set; }
        public DbSet<Promotion> Promotion { get; set; }
        public DbSet<Slide> Slide { get; set; }
        public DbSet<Transactions> Transactions { get; set; }
    }
}
