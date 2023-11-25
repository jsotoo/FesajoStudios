using FesajoStudios.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.DataAccess.Configurations
{
    public class ClientConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.Property(x => x.FirstName)
                  .HasMaxLength(200);

            builder.Property(x => x.LastName)
                .HasMaxLength(200);

            builder.Property(x => x.Email)
                .IsUnicode(false)
                .HasMaxLength(500);

            builder.Property(x => x.Birthdate)
                .HasColumnType("DATE");
        }
    }
}
