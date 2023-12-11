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
    public class ShowingConfiguration : IEntityTypeConfiguration<Showing>
    {
        public void Configure(EntityTypeBuilder<Showing> builder)
        {
            builder.HasData(new List<Showing>
            {
                new() { Id = 1, StartDate = new DateTime(2023,12,20,14,10,0), EndDate = new DateTime(2023,12,20,15,45,0), MovieId = 2, TheatherId = 1, State = true  },
                new() { Id = 2, StartDate = new DateTime(2023,12,11,12,0,0), EndDate = new DateTime(2023,12,11,13,30,0), MovieId = 3, TheatherId = 2, State = true  },
                new() { Id = 3, StartDate = new DateTime(2023,12,9,16,5,0), EndDate = new DateTime(2023,12,9,16,5,0), MovieId = 2, TheatherId = 3, State = true  },
                new() { Id = 4, StartDate = new DateTime(2023,12,24,20,45,0), EndDate = new DateTime(2023,12,24,22,45,0), MovieId = 7, TheatherId = 2, State = true  },
                new() { Id = 5, StartDate = new DateTime(2023,12,16,20,50,0), EndDate = new DateTime(2023,12,16,22,30,0), MovieId = 5, TheatherId = 4, State = true  },
                new() { Id = 6, StartDate = new DateTime(2023,12,28,14,0,0), EndDate = new DateTime(2023,12,28,13,30,0), MovieId = 7, TheatherId = 3, State = true  },
                new() { Id = 7, StartDate = new DateTime(2023,12,13,13,30,0), EndDate = new DateTime(2023,12,13,14,0,0), MovieId = 1, TheatherId = 4, State = true  },
                new() { Id = 8, StartDate = new DateTime(2023,12,14,16,0,0), EndDate = new DateTime(2023,12,14,17,45,0), MovieId = 6, TheatherId = 1, State = true  },
                new() { Id = 9, StartDate = new DateTime(2023,12,18,12,0,0), EndDate = new DateTime(2023,12,18,1,40,0), MovieId = 6, TheatherId = 1, State = true  },
            });
        }
    }
}
