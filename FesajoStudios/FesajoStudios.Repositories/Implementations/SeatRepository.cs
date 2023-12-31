﻿using FesajoStudios.DataAccess.Data;
using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Repositories.Implementations
{
    public class SeatRepository : RepositoryBase<Seat>, ISeatRepository
    {
        private readonly FesajoStudiosDbContext _context;

        public SeatRepository(FesajoStudiosDbContext context) : base(context)
        {
            _context = context;
        }



        public async Task UpdateAsyncEntity(Seat seat)
        {
            _context.Entry(seat).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }



    }
}
