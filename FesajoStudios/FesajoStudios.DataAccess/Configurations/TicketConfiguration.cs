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
    public class TicketConfiguration : IEntityTypeConfiguration<Ticket>
    {
        public void Configure(EntityTypeBuilder<Ticket> builder)
        {
            builder.Property(x => x.Price)
                .HasPrecision(11, 2);
            
            builder.HasData(new List<Ticket>
            {
                new() { Id = 1, TicketTypeId = 1, ShowingId= 1, Price =15000 , State = true  },
                new() { Id = 2, TicketTypeId = 2, ShowingId= 1, Price =8000 , State = true },
                new() { Id = 3, TicketTypeId = 3, ShowingId = 1,Price =10000 , State = true},
                new() { Id = 4, TicketTypeId = 1, ShowingId = 2,Price =15000 , State = true },
                new() { Id = 5, TicketTypeId = 2, ShowingId= 2 ,Price =8000 , State = true },
                new() { Id = 6, TicketTypeId = 3, ShowingId= 2, Price =10000 ,State = true },
                new() { Id = 7, TicketTypeId = 1, ShowingId = 3,Price =15000 , State = true },
                new() { Id = 8, TicketTypeId = 2, ShowingId = 3, Price =8000 ,State = true },
                new() { Id = 9, TicketTypeId = 3, ShowingId= 3 , Price =10000 ,State = true },
                new() { Id = 10, TicketTypeId = 1, ShowingId= 4 ,Price =15000 , State = true},
                new() { Id = 11, TicketTypeId = 2, ShowingId = 4 ,Price =8000 , State = true},
                new() { Id = 12, TicketTypeId = 3, ShowingId = 4, Price =10000 ,State = true },
                new() { Id = 13, TicketTypeId = 1, ShowingId= 5, Price =15000 ,State = true  },
                new() { Id = 14, TicketTypeId = 2, ShowingId= 5, Price =8000 ,State = true },
                new() { Id = 15, TicketTypeId = 3, ShowingId = 5, Price =10000 ,State = true },
                new() { Id = 16, TicketTypeId = 1, ShowingId = 6, Price =15000 ,State = true },
                new() { Id = 17, TicketTypeId = 2, ShowingId= 6 , Price =8000 ,State = true },
                new() { Id = 18, TicketTypeId = 3, ShowingId= 6 , Price =10000 ,State = true},
                new() { Id = 19, TicketTypeId = 1, ShowingId = 7, Price =15000 ,State = true },
                new() { Id = 20, TicketTypeId = 2, ShowingId = 7, Price =8000 ,State = true },
                new() { Id = 21, TicketTypeId = 3, ShowingId= 7 , Price =10000 ,State = true },
                new() { Id = 22, TicketTypeId = 1, ShowingId= 8, Price =15000 ,State = true },
                new() { Id = 23, TicketTypeId = 2, ShowingId = 8, Price =8000 ,State = true },
                new() { Id = 24, TicketTypeId = 3, ShowingId = 8, Price =10000 ,State = true },
                new() { Id = 25, TicketTypeId = 1, ShowingId= 9, Price =15000 ,State = true  },
                new() { Id = 26, TicketTypeId = 2, ShowingId= 9 , Price =8000 ,State = true},
                new() { Id = 27, TicketTypeId = 3, ShowingId = 9, Price =10000 ,State = true },
               
            });


        }
    }
}
