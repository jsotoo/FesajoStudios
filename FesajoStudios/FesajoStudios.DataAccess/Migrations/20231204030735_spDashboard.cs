using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class spDashboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                CREATE PROCEDURE sp_Dashboard
                AS
                BEGIN
                    SELECT
                        (SELECT COUNT(*) FROM Client WHERE State = 1) AS TotalClients,
                        (SELECT COUNT(*) FROM SeatXBooking WHERE State = 1) AS TotalBookings,
                        (SELECT SUM(Total) FROM Booking WHERE State = 1) AS TotalSales,
                        (SELECT COUNT(*) FROM Movie WHERE State = 1) AS TotalMovies;
                END;
                GO ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROC sp_Dashboard");
        }
    }
}
