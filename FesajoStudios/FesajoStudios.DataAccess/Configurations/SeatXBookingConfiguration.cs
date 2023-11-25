using FesajoStudios.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.DataAccess.Configurations
{
    public class SeatXBookingConfiguration : IEntityTypeConfiguration<SeatXBooking>
    {
  
        public void Configure(EntityTypeBuilder<SeatXBooking> builder)
        {
          
        }
    }
}
