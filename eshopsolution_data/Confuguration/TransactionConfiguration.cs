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
    public class TransactionConfiguration : IEntityTypeConfiguration<Transactions>
    {
        public void Configure(EntityTypeBuilder<Transactions> builder)
        {
            builder.ToTable("Transactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.HasOne(x => x.AppUser).WithMany(x => x.Transactions).HasForeignKey(x => x.UserId);

        }
    }
}
