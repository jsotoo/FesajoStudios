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


        }
    }
}
