using FesajoStudios.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Repositories.Interfaces
{
    public interface ISeatRepository : IRepositoryBase<Seat>
    {
        Task<ICollection<Seat>> GetSeatsFromShowingId(int id);


    }
}
