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
    public class TicketTypeConfiguration : IEntityTypeConfiguration<TicketType>
    {
        public void Configure(EntityTypeBuilder<TicketType> builder)
        {
            builder.Property(x => x.Description)
            .HasMaxLength(50);

            builder.HasData(new List<TicketType>
            {
                new() { Id = 1, Description = "Adulto" },
                new() { Id = 2, Description = "Niño" },
                new() { Id = 3, Description = "Estudiante" },
            });
        }
    }
}
