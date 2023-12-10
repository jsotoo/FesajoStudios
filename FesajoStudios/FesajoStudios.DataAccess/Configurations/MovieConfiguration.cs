using FesajoStudios.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace FesajoStudios.DataAccess.Configurations
{
    public class MovieConfiguration : IEntityTypeConfiguration<Movie>
    {
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder
                .Property(x => x.Title)
                .HasMaxLength(60);
            builder
                .Property(x => x.Description)
                .HasMaxLength(500);
            builder
                .Property(x => x.Rating)
                .HasMaxLength(50);
            builder
                .Property(x => x.Director)
                 .HasMaxLength(70);
            builder
                .Property(x => x.Genre)
                .HasMaxLength(30);
            builder
                .Property(x => x.ReleaseDate)
                .HasColumnType("DATE");


            builder.HasData(new List<Movie>
            {
                new() { Id = 1, Title = "Shape of water", Description= " Elisa, muda desde que era un bebé, trabaja como limpiadora nocturna en un centro de investigación aeroespacial. Una noche, mientras está limpiando en un zona de alta seguridad, ve cómo llevan al laboratorio una cápsula con un extraño ser en su interior.", Duration = TimeSpan.FromHours(2), Rating = "16+",Director = "Guillermo del toro", Genre = "Fantasia",ReleaseDate = new DateTime(2017, 2, 3), State = true, UrlImage = "/uploads/sow.jpg"  },
                new() { Id = 2, Title = "Avatar", Description= "Más de una década después de los acontecimientos de 'Avatar', los Na'vi Jake Sully, Neytiri y sus hijos viven en paz en los bosques de Pandora hasta que regresan los hombres del cielo. Entonces comienzan los problemas que persiguen sin descanso a la familia Sully, que decide hacer un gran sacrificio para mantener a su pueblo a salvo y seguir ellos con vida.", Duration = TimeSpan.FromHours(3), Rating = "13+", Director = "James Cameron", Genre="Fantasia", ReleaseDate = new DateTime(2009, 1, 3), State = true, UrlImage = "/uploads/avatar.jpg" },
                new() { Id = 3, Title = "Matrix", Description= "Un experto en computadoras descubre que su mundo es una simulación total creada con maliciosas intenciones por parte de la ciberinteligencia.", Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(33)), Rating = "16+", Director = "Hermanas Wachowski", Genre = "Ciencia Ficción", ReleaseDate = new DateTime(1999, 5, 21), State = true, UrlImage = "/uploads/Matrix.jpg"  },
                new() { Id = 4, Title = "Salvar al soldado Ryan", Description= "Después de desembarcar en Normandía, en plena Segunda Guerra Mundial, unos soldados norteamericanos deben arriesgar sus vidas para salvar al soldado James Ryan, cuyos tres hermanos han muerto en la guerra.", Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(30)), Rating = "18+", Director = "Steven Spielberg", Genre = "Belico", ReleaseDate = new DateTime(1999,3,12), State = true, UrlImage = "/uploads/Salvar_al_soldado_Ryan.jpg" },
                new() { Id = 5, Title = "Saw X", Description= "John Kramer conoce a una persona que le promete curarle el cáncer en una clínica de la Ciudad de México. Tras descubrir que todo era una estafa, se venga de los timadores secuestrándolos y obligándolos a participar en un juego perverso.", Duration = TimeSpan.FromHours(2), Rating = "18+", Director = "Kevin Greutert", Genre = "Terror", ReleaseDate =  new DateTime(2023,9,23), State = true, UrlImage = "/uploads/Saw X.png" },
                new() { Id = 6, Title = "Oppenheimer", Description= "Durante la Segunda Guerra Mundial, el teniente general Leslie Groves designa al físico J. Robert Oppenheimer para un grupo de trabajo que está desarrollando el Proyecto Manhattan, cuyo objetivo consiste en fabricar la primera bomba atómica.", Duration = TimeSpan.FromHours(3), Rating = "16+", Director = "Christopher Nolan", Genre = "Suspenso", ReleaseDate = new DateTime(2023,7,21), State = true, UrlImage = "/uploads/oppenheimer.jpg" },
                new() { Id = 7, Title = "El laberinto del fauno", Description= "España, 1944, la joven Ofelia (Ivana Baquero) y su madre (Ariadna Gil) enferma llegan al sitio en el que se encuentra el nuevo esposo (Sergi López) de su madre, un sádico oficial del ejército que intenta calmar el levantamiento de una guerrilla.", Duration = TimeSpan.FromHours(1).Add(TimeSpan.FromMinutes(30)), Rating = "18+", Director = "Guillermo del Toro", Genre = "Fantasia Belica", ReleaseDate = new DateTime(2007,2,23), State = true, UrlImage = "/uploads/LaberintoDelFauno.jpg"    },
            });

        }
    }
}
