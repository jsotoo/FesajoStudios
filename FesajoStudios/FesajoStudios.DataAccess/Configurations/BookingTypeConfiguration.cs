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
    public class BookingTypeConfiguration : IEntityTypeConfiguration<BookingType>
    {
        public void Configure(EntityTypeBuilder<BookingType> builder)
        {
            builder.Property(x => x.Description)
           .HasMaxLength(70);

            builder.HasData(new List<BookingType>
            {
                new() { Id = 1, Description = "Confirmado" },
                new() { Id = 2, Description = "Pendiente" },
                new() { Id = 3, Description = "Cancelado" },
            });
        }
    }
}
