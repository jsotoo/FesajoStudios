using Dapper;
using FesajoStudios.DataAccess.Data;
using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

using System.Data;


namespace FesajoStudios.Repositories.Implementations
{
    public class BookingRepository : RepositoryBase<Booking>, IBookingRepository
    {
        private readonly FesajoStudiosDbContext _context;
        public BookingRepository(FesajoStudiosDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Dashboard> ShowDashboard()
        {
            var query = await _context.Database.GetDbConnection()
              .QuerySingleAsync<Dashboard>("sp_Dashboard", commandType: CommandType.StoredProcedure);

            return query;
        }

    



    }
}
