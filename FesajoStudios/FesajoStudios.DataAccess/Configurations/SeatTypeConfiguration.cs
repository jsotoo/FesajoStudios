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
    public class SeatTypeConfiguration : IEntityTypeConfiguration<SeatType>
    {
        public void Configure(EntityTypeBuilder<SeatType> builder)
        {
            builder.Property(x => x.Description)
            .HasMaxLength(70);

            builder.HasData(new List<SeatType>
            {
                new() { Id = 1, Description = "Disponible" },
                new() { Id = 2, Description = "Ocupado" },
            });
        }
    }
}
