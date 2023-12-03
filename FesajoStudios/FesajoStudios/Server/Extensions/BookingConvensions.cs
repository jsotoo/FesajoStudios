using FesajoStudios.Entities;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Reponse;

namespace FesajoStudios.Server.Extensions
{
    public static class BookingConvensions
    {
        public static IEnumerable<BookingDtoResponse> GetByIdConvertToDto(this IEnumerable<Booking> bookings,
                                                                               IEnumerable<BookingType> bookingsType,
                                                                               IEnumerable<Entities.Client> clients,
                                                                               IEnumerable<Showing> showings, IEnumerable<Movie> movies,int id)
        {
            return (from booking in bookings
                    join bookingType in bookingsType on booking.BookingTypeId equals bookingType.Id
                    join client in clients on booking.ClientId equals client.Id
                    join showing in showings on booking.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where client.Id == id
                    select new BookingDtoResponse
                    {
                        Id = booking.Id,
                        Client = client.FirstName + " " + client.LastName,
                        BookingType = bookingType.Description,
                        ReservationDate = booking.ReservationDate,
                        Showing = movie.Title

                    }).ToList();

        }

        public static BookingDtoResponse? GetByBookingIdConvertToDto(this IEnumerable<Booking> bookings,
                                                                          IEnumerable<BookingType> bookingsType,
                                                                          IEnumerable<Entities.Client> clients,
                                                                          IEnumerable<Showing> showings, IEnumerable<Movie> movies, int id)
        {
            return (from booking in bookings
                    join bookingType in bookingsType on booking.BookingTypeId equals bookingType.Id
                    join client in clients on booking.ClientId equals client.Id
                    join showing in showings on booking.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where booking.Id == id 
                    select new BookingDtoResponse
                    {
                        Id = booking.Id,
                        Client = client.FirstName + " " + client.LastName,
                        BookingType = bookingType.Description,
                        ReservationDate = booking.ReservationDate,
                        Showing = movie?.Title,
                        movieImage = movie.UrlImage
                    }).FirstOrDefault();
        }


        public static BookingDtoResponse? GetBySeatIdAndShowingIdConvertToDto(this IEnumerable<Booking> bookings,
                                                                          IEnumerable<BookingType> bookingsType,
                                                                          IEnumerable<SeatXBooking> seatsXbookings,
                                                                          IEnumerable<Entities.Client> clients,
                                                                          IEnumerable<Showing> showings, IEnumerable<Movie> movies, int Seatid, int ShowingId)
        {
            return (from booking in bookings
                    join bookingType in bookingsType on booking.BookingTypeId equals bookingType.Id
                    join seatXbooking in seatsXbookings on booking.Id equals seatXbooking.BookingId
                    join client in clients on booking.ClientId equals client.Id
                    join showing in showings on booking.ShowingId equals showing.Id
                    join movie in movies on showing.MovieId equals movie.Id
                    where seatXbooking.SeatId == Seatid && showing.Id == ShowingId
                    select new BookingDtoResponse
                    {
                        Id = booking.Id,
                        Client = client.FirstName + " " + client.LastName,
                        BookingType = bookingType.Description,
                        ReservationDate = booking.ReservationDate,
                        Showing = movie?.Title,
                        movieImage = movie.UrlImage
                    }).FirstOrDefault();
        }



    }
}
