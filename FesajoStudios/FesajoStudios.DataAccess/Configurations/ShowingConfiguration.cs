﻿using FesajoStudios.Entities;
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
            
        }
    }
}
