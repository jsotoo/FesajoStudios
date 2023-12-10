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
    public class TheatherConfiguration : IEntityTypeConfiguration<Theather>
    {
        public void Configure(EntityTypeBuilder<Theather> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(50);

            builder.HasData(new List<Theather>
            {
                new() { Id = 1, Name = "Sala 1", Capacity= 100  },
                new() { Id = 2, Name = "Sala 2", Capacity= 100 },
                new() { Id = 3, Name = "Sala 3", Capacity = 100 },
                new() { Id = 4, Name = "Sala 4", Capacity = 100 },
            });


        }
    }
}
