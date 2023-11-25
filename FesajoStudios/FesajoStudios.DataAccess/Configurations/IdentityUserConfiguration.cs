using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.DataAccess.Configurations
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUserFesajoStudios>
    {
        public void Configure(EntityTypeBuilder<IdentityUserFesajoStudios> builder)
        {
            builder.Property(p => p.FullName)
                 .HasMaxLength(200);
            builder.Property(p => p.BirthDate)
                 .HasColumnType("DATE");
            builder.Property(p => p.Address)
                .HasMaxLength(500);

        }
    }
}
