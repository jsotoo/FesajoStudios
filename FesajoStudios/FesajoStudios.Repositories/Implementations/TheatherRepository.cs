using FesajoStudios.DataAccess.Data;
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
    public class TheatherRepository : RepositoryBase<Theather>, ITheatherRepository
    {
        private readonly FesajoStudiosDbContext _context;

        public TheatherRepository(FesajoStudiosDbContext context) : base(context)
        {
            _context = context;
        }


    }
}
