using FesajoStudios.Client.Shared;
using FesajoStudios.Entities;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Reponse;
using System.Runtime.Intrinsics.Arm;

namespace FesajoStudios.Server.Extensions
{
    public static class SeatConvensions
    {
        public static IEnumerable<SeatDto> GetConvertToDto(this IEnumerable<Seat> seats,
                                                             IEnumerable<SeatType> seatsType,
                                                             IEnumerable<Theather> theathers,
                                                             IEnumerable<Showing> showings,
                                                             IEnumerable<Movie> movies)
        {
            return (from seat in seats
                    join seatType in seatsType on seat.SeatTypeId equals seatType.Id
                    join theather in theathers on seat.TheatherId equals theather.Id
                    join showing in showings on theather.Id equals showing.TheatherId
                    join movie in movies on showing.MovieId equals movie.Id
                    select new SeatDto
                    {
                        Id = seat.Id,
                        SeatCode = seat.SeatCode,
                        SeatTypeId = seat.SeatTypeId,
                        ShowingId = showing.Id,
                        SeatType = seatType.Description,
                        Showing = movie.Title

                    }).ToList();

        }


        public static IEnumerable<SeatDto> GetByIdConvertToDto(this IEnumerable<Seat> seats,
                                                            IEnumerable<SeatType> seatsType,
                                                            IEnumerable<Theather> theathers,
                                                            IEnumerable<Showing> showings,
                                                            IEnumerable<Movie> movies, int id)
        {
            return (from seat in seats
                    join seatType in seatsType on seat.SeatTypeId equals seatType.Id
                    join theather in theathers on seat.TheatherId equals theather.Id
                    join showing in showings on theather.Id equals showing.TheatherId
                    join movie in movies on showing.MovieId equals movie.Id
                    select new SeatDto
                    {
                        Id = seat.Id,
                        SeatCode = seat.SeatCode,
                        SeatTypeId = seat.SeatTypeId,
                        ShowingId = showing.Id,
                        SeatType = seatType.Description,
                        Showing = movie.Title

                    })
                    .Where(s => s.Id == id)
                    .ToList();

        }

        public static IEnumerable<SeatDto> GetByShowingIdConvertToDto(this IEnumerable<Seat> seats,
                                                           IEnumerable<SeatType> seatsType,
                                                           IEnumerable<Theather> theathers,
                                                           IEnumerable<Showing> showings,
                                                           IEnumerable<Movie> movies, int id)
        {
            return (from seat in seats
                    join seatType in seatsType on seat.SeatTypeId equals seatType.Id
                    join theather in theathers on seat.TheatherId equals theather.Id
                    join showing in showings on seat.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where showing.Id == id
                    select new SeatDto
                    {
                        Id = seat.Id,
                        SeatCode = seat.SeatCode,
                        SeatTypeId = seat.SeatTypeId,
                        ShowingId = showing.Id,
                        SeatType = seatType.Description,
                        Showing = movie.Title

                        
                    })
                    .ToList();

        }

        public static IEnumerable<SeatDtoResponse> GetByBookingIdConvertToDto(this IEnumerable<Seat> seats,
                                                         IEnumerable<SeatXBooking> seatsXBookings,
                                                         IEnumerable<SeatType> seatsType,
                                                         IEnumerable<Theather> theathers,
                                                         IEnumerable<Showing> showings,
                                                         IEnumerable<Movie> movies, int id)
        {
            return (from seat in seats
                    join seatXbooking in seatsXBookings on seat.Id equals seatXbooking.SeatId
                    join seatType in seatsType on seat.SeatTypeId equals seatType.Id
                    join theather in theathers on seat.TheatherId equals theather.Id
                    join showing in showings on seat.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where seatXbooking.BookingId == id
                    select new SeatDtoResponse
                    {
                        Id = seat.Id,
                        SeatCode = seat.SeatCode,
                        SeatTypeId = seat.SeatTypeId,
                        ShowingId = showing.Id,
                        SeatType = seatType.Description,
                        Showing = movie.Title

                    }).ToList();

        }
        public static IEnumerable<SeatDtoResponse> GetSeatsByTheatherIdConvertToDto(this IEnumerable<Seat> seats,
                                                                                            IEnumerable<SeatType> seatsType,
                                                                                            IEnumerable<Theather> theathers,
                                                                                            IEnumerable<Showing> showings,
                                                                                            IEnumerable<Movie> movies, int id)
        {
            return (from seat in seats
                    join seatType in seatsType on seat.SeatTypeId equals seatType.Id
                    join theather in theathers on seat.TheatherId equals theather.Id
                    join showing in showings on seat.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where seat.TheatherId == id
                    select new SeatDtoResponse
                    {
                        Id = seat.Id,
                        SeatCode = seat.SeatCode,
                        SeatTypeId = seat.SeatTypeId,
                        ShowingId = showing.Id,
                        SeatType = seatType.Description,
                        Showing = movie.Title

                    }).ToList();

        }
        
    }
}
