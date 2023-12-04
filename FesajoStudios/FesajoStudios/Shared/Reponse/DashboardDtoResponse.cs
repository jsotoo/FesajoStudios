using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FesajoStudios.Shared.Reponse
{
    public class DashboardDtoResponse
    {
        public int TotalClients { get; set; }
        public int TotalBookings { get; set; }
        public decimal TotalSales { get; set; }
        public int TotalMovies { get; set; }
    }
}
