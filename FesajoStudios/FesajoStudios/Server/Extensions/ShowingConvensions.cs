using FesajoStudios.Entities;
using FesajoStudios.Shared;
using FesajoStudios.Shared.Reponse;

namespace FesajoStudios.Server.Extensions
{
    public static class ShowingConvensions
    {
        public static IEnumerable<ShowingDto> ConvertToDtoGetShowingsByMovieId(this IEnumerable<Showing> showings,
                                                             IEnumerable<Movie> movies,
                                                             IEnumerable<Theather> theathers, int id)
        {
            return (from movie in movies
                    
                    join showing in showings on movie.Id equals showing.MovieId
                    join theather in theathers on showing.TheatherId equals theather.Id
                    where movie.Id == id
                    select new ShowingDto
                    {
                        Id = showing.Id,
                        StartDate = showing.StartDate,
                        EndDate = showing.EndDate,
                        Theather = theather.Name,
                        Movie = movie.Title,
                        MovieId = movie.Id,
                        TheatherId = theather.Id
                        

                    })
                    .ToList();

        }

        public static ShowingDtoResponse ConvertToDtoGetShowingsById(this IEnumerable<Showing> showings,
                                                                      IEnumerable<Movie> movies,
                                                                      IEnumerable<Theather> theathers, int id)
        {
            var result = (from movie in movies
                          join showing in showings on movie.Id equals showing.MovieId
                          join theather in theathers on showing.TheatherId equals theather.Id
                          where showing.Id == id
                          select new ShowingDtoResponse
                          {
                              Id = showing.Id,
                              StartDate = showing.StartDate,
                              EndDate = showing.EndDate,
                              Theather = theather?.Name ?? "N/A", 
                              Movie = movie?.Title ?? "N/A",
                              MovieId = movie?.Id ?? 0, 
                              TheatherId = theather?.Id ?? 0 
                          })
                         .SingleOrDefault();

            return result ?? new ShowingDtoResponse(); 
        }





    }
}
