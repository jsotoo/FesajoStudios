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
          
        }
    }
}
