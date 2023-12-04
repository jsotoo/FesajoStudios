using FesajoStudios.Entities;
using FesajoStudios.Shared.Reponse;

namespace FesajoStudios.Server.Extensions
{
    public static class MovieConvensions
    {
        public static MovieDtoResponse? GetMoviesByShowingIdConvertToDto(this IEnumerable<Movie> movies, IEnumerable<Showing> showings, int id)
        {
            return (from movie in movies
                    join showing in showings on movie.Id equals showing.MovieId
                    where showing.Id == id
                    select new MovieDtoResponse
                    {
                        Id = movie.Id,
                        Title = movie.Title,
                        Description = movie.Description,
                        Director = movie.Director,
                        Duration = movie.Duration,
                        Genre = movie.Genre,
                        Rating = movie.Rating,
                        ReleaseDate = movie.ReleaseDate,
                        UrlImage = movie.UrlImage
                    }).FirstOrDefault();
        }



    }
}
