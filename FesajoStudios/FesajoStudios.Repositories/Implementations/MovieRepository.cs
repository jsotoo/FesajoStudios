using FesajoStudios.DataAccess.Data;
using FesajoStudios.Entities;
using FesajoStudios.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Repositories.Implementations
{
    public class MovieRepository : RepositoryBase<Movie>, IMovieRepository
    {
        public MovieRepository(FesajoStudiosDbContext context) : base(context)
        {
        }
    }
}
