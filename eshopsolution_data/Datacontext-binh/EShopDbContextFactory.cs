﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace eshopsolution_data.Datacontext_binh
{
    public class EShopDbContextFactory : IDesignTimeDbContextFactory<eshopdbcontexxt>
    {
        public eshopdbcontexxt CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("eshopsolutiondb");

            var optionsBuilder = new DbContextOptionsBuilder<eshopdbcontexxt>();
            optionsBuilder.UseSqlServer(connectionString);

            return new eshopdbcontexxt(optionsBuilder.Options);
        }
    }
}
