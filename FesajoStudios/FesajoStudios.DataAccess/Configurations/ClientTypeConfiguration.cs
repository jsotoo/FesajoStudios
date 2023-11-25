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
    public class ClientTypeConfiguration : IEntityTypeConfiguration<ClientType>
    {
        public void Configure(EntityTypeBuilder<ClientType> builder)
        {
            builder.Property(x => x.Description)
            .HasMaxLength(70);

            builder.HasData(new List<ClientType>
            {
                new() { Id = 1, Description = "Cliente Normal" },
                new() { Id = 2, Description = "Cliente Especial" },
            });
        }
    }
}
