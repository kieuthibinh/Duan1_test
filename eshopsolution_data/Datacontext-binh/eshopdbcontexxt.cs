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
        public DbSet<Hang> Hangs { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<LichSu> LichSus { get; set; }
    }
}
