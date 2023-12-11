using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class populateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "Director", "Duration", "Genre", "Rating", "ReleaseDate", "State", "Title", "UrlImage" },
                values: new object[,]
                {
                    { 1, " Elisa, muda desde que era un bebé, trabaja como limpiadora nocturna en un centro de investigación aeroespacial. Una noche, mientras está limpiando en un zona de alta seguridad, ve cómo llevan al laboratorio una cápsula con un extraño ser en su interior.", "Guillermo del toro", new TimeSpan(0, 2, 0, 0, 0), "Fantasia", "16+", new DateTime(2017, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Shape of water", "/uploads/sow.jpg" },
                    { 2, "Más de una década después de los acontecimientos de 'Avatar', los Na'vi Jake Sully, Neytiri y sus hijos viven en paz en los bosques de Pandora hasta que regresan los hombres del cielo. Entonces comienzan los problemas que persiguen sin descanso a la familia Sully, que decide hacer un gran sacrificio para mantener a su pueblo a salvo y seguir ellos con vida.", "James Cameron", new TimeSpan(0, 3, 0, 0, 0), "Fantasia", "13+", new DateTime(2009, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Avatar", "/uploads/avatar.jpg" },
                    { 3, "Un experto en computadoras descubre que su mundo es una simulación total creada con maliciosas intenciones por parte de la ciberinteligencia.", "Hermanas Wachowski", new TimeSpan(0, 1, 33, 0, 0), "Ciencia Ficción", "16+", new DateTime(1999, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Matrix", "/uploads/Matrix.jpg" },
                    { 4, "Después de desembarcar en Normandía, en plena Segunda Guerra Mundial, unos soldados norteamericanos deben arriesgar sus vidas para salvar al soldado James Ryan, cuyos tres hermanos han muerto en la guerra.", "Steven Spielberg", new TimeSpan(0, 1, 30, 0, 0), "Belico", "18+", new DateTime(1999, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Salvar al soldado Ryan", "/uploads/Salvar_al_soldado_Ryan.jpg" },
                    { 5, "John Kramer conoce a una persona que le promete curarle el cáncer en una clínica de la Ciudad de México. Tras descubrir que todo era una estafa, se venga de los timadores secuestrándolos y obligándolos a participar en un juego perverso.", "Kevin Greutert", new TimeSpan(0, 2, 0, 0, 0), "Terror", "18+", new DateTime(2023, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Saw X", "/uploads/Saw X.png" },
                    { 6, "Durante la Segunda Guerra Mundial, el teniente general Leslie Groves designa al físico J. Robert Oppenheimer para un grupo de trabajo que está desarrollando el Proyecto Manhattan, cuyo objetivo consiste en fabricar la primera bomba atómica.", "Christopher Nolan", new TimeSpan(0, 3, 0, 0, 0), "Suspenso", "16+", new DateTime(2023, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "Oppenheimer", "/uploads/oppenheimer.jpg" },
                    { 7, "España, 1944, la joven Ofelia (Ivana Baquero) y su madre (Ariadna Gil) enferma llegan al sitio en el que se encuentra el nuevo esposo (Sergi López) de su madre, un sádico oficial del ejército que intenta calmar el levantamiento de una guerrilla.", "Guillermo del Toro", new TimeSpan(0, 1, 30, 0, 0), "Fantasia Belica", "18+", new DateTime(2007, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), true, "El laberinto del fauno", "/uploads/LaberintoDelFauno.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Theather",
                columns: new[] { "Id", "Capacity", "Name", "State" },
                values: new object[,]
                {
                    { 1, 100, "Sala 1", true },
                    { 2, 100, "Sala 2", true },
                    { 3, 100, "Sala 3", true },
                    { 4, 100, "Sala 4", true }
                });

            migrationBuilder.InsertData(
                table: "Showing",
                columns: new[] { "Id", "EndDate", "MovieId", "StartDate", "State", "TheatherId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 12, 20, 15, 45, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 12, 20, 14, 10, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 2, new DateTime(2023, 12, 2, 13, 30, 0, 0, DateTimeKind.Unspecified), 3, new DateTime(2023, 12, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 3, new DateTime(2023, 11, 16, 16, 5, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2023, 11, 16, 16, 5, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 4, new DateTime(2023, 12, 24, 22, 45, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2023, 12, 24, 20, 45, 0, 0, DateTimeKind.Unspecified), true, 2 },
                    { 5, new DateTime(2023, 12, 16, 22, 30, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2023, 12, 16, 20, 50, 0, 0, DateTimeKind.Unspecified), true, 4 },
                    { 6, new DateTime(2023, 12, 28, 13, 30, 0, 0, DateTimeKind.Unspecified), 7, new DateTime(2023, 12, 28, 14, 0, 0, 0, DateTimeKind.Unspecified), true, 3 },
                    { 7, new DateTime(2023, 12, 4, 14, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2023, 12, 4, 13, 30, 0, 0, DateTimeKind.Unspecified), true, 4 },
                    { 8, new DateTime(2023, 12, 14, 17, 45, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 12, 14, 16, 0, 0, 0, DateTimeKind.Unspecified), true, 1 },
                    { 9, new DateTime(2023, 12, 18, 1, 40, 0, 0, DateTimeKind.Unspecified), 6, new DateTime(2023, 12, 18, 12, 0, 0, 0, DateTimeKind.Unspecified), true, 1 }
                });

            migrationBuilder.InsertData(
                table: "Ticket",
                columns: new[] { "Id", "Price", "ShowingId", "State", "TicketTypeId" },
                values: new object[,]
                {
                    { 1, 15000m, 1, true, 1 },
                    { 2, 8000m, 1, true, 2 },
                    { 3, 10000m, 1, true, 3 },
                    { 4, 15000m, 2, true, 1 },
                    { 5, 8000m, 2, true, 2 },
                    { 6, 10000m, 2, true, 3 },
                    { 7, 15000m, 3, true, 1 },
                    { 8, 8000m, 3, true, 2 },
                    { 9, 10000m, 3, true, 3 },
                    { 10, 15000m, 4, true, 1 },
                    { 11, 8000m, 4, true, 2 },
                    { 12, 10000m, 4, true, 3 },
                    { 13, 15000m, 5, true, 1 },
                    { 14, 8000m, 5, true, 2 },
                    { 15, 10000m, 5, true, 3 },
                    { 16, 15000m, 6, true, 1 },
                    { 17, 8000m, 6, true, 2 },
                    { 18, 10000m, 6, true, 3 },
                    { 19, 15000m, 7, true, 1 },
                    { 20, 8000m, 7, true, 2 },
                    { 21, 10000m, 7, true, 3 },
                    { 22, 15000m, 8, true, 1 },
                    { 23, 8000m, 8, true, 2 },
                    { 24, 10000m, 8, true, 3 },
                    { 25, 15000m, 9, true, 1 },
                    { 26, 8000m, 9, true, 2 },
                    { 27, 10000m, 9, true, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Ticket",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Showing",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Theather",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Theather",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Theather",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Theather",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
