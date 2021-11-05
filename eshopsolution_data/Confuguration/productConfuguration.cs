using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshopsolution_data.entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eshopsolution_data.Confuguration
{
    public class productConfuguration:IEntityTypeConfiguration<product>
    {
        public void Configure(EntityTypeBuilder<product> builder)
        {
            builder.ToTable("product");
            builder.HasKey(x => x.id);
            builder.Property(x => x.price).IsRequired();
            builder.Property(x => x.originalprice).IsRequired();
            builder.Property(x => x.SeoAlias).IsRequired();
            builder.Property(x => x.ViewCount).IsRequired();
        }
    }
}
