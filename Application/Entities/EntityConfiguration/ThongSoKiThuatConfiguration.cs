using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Entities.EntityConfiguration
{
    public class ThongSoKiThuatConfiguration : IEntityTypeConfiguration<ThongSoKiThuat>
    {
        public void Configure(EntityTypeBuilder<ThongSoKiThuat> builder)
        {
            builder.ToTable("ThongSoKiThuats");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Product)
                .WithMany(ur => ur.ThongSoKiThuats)
                .HasForeignKey(k => k.ProductId)
                .IsRequired();
        }
    }
}
