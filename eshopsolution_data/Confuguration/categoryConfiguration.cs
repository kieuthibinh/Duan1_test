using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eshopsolution_data.entitys;
using eshopsolution_data.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eshopsolution_data.Confuguration
{
    public class categoryConfiguration:IEntityTypeConfiguration<Categorycs>
    {
        public void Configure(EntityTypeBuilder<Categorycs> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.id);
            builder.Property(x => x.status).HasDefaultValue(Status.Active);
        }
    }
}
