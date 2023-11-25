using FesajoStudios.Repositories.Implementations;
using FesajoStudios.Repositories.Interfaces;
using FesajoStudios.Server.Services;

namespace FesajoStudios.Server.DependencyInjection
{
    public static class Dependencies
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IMovieRepository, MovieRepository>()
                    .AddTransient<ISeatRepository, SeatRepository>()
                    .AddTransient<IShowingRepository, ShowingRepository>()
                    .AddTransient<ITheatherRepository, TheatherRepository>()
                    .AddTransient<ITicketRepository, TicketRepository>()
                    .AddTransient<ISeatTypeRepository, SeatTypeRepository>()
                    .AddTransient<ITicketTypeRepository, TicketTypeRepository>()
                    .AddTransient<IClientRepository, ClientRepository>()
                    .AddTransient<IBookingRepository, BookingRepository>()
                    .AddTransient<ISeatXBookingRepository, SeatXBookingRepository>() ;

            return services;
        }
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            return services.AddTransient<IFileUploader, FileUploader>()
                           .AddTransient<IUserService, UserService>();  
                
        }
    }
}
