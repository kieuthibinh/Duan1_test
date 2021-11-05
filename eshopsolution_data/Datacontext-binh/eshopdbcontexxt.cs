using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshopsolution_data.Confuguration;
using eshopsolution_data.entitys;
using Microsoft.EntityFrameworkCore;

namespace eshopsolution_data.Datacontext_binh
{
    public class eshopdbcontexxt:DbContext
    {
        public eshopdbcontexxt(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CartConfiguration());

            modelBuilder.ApplyConfiguration(new AddConfuguration());
            modelBuilder.ApplyConfiguration(new productConfuguration());
            modelBuilder.ApplyConfiguration(new categoryConfiguration());
            modelBuilder.ApplyConfiguration(new produckincategoryConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());

            modelBuilder.ApplyConfiguration(new OrderdetailConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new ContactConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTranslationConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new TransactionConfiguration());

            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductImageConfiguration());
            modelBuilder.ApplyConfiguration(new SlideConfiguration());
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
