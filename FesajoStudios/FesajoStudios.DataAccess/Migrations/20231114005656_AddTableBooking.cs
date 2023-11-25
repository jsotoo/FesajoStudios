using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddTableBooking : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookingType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(70)", maxLength: 70, nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Booking",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReservationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookingTypeId = table.Column<int>(type: "int", nullable: false),
                    ShowingId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Booking", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Booking_BookingType_BookingTypeId",
                        column: x => x.BookingTypeId,
                        principalTable: "BookingType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Booking_Showing_ShowingId",
                        column: x => x.ShowingId,
                        principalTable: "Showing",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "BookingType",
                columns: new[] { "Id", "Description", "State" },
                values: new object[,]
                {
                    { 1, "Confirmado", true },
                    { 2, "Pendiente", true },
                    { 3, "Cancelado", true }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Booking_BookingTypeId",
                table: "Booking",
                column: "BookingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ClientId",
                table: "Booking",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Booking_ShowingId",
                table: "Booking",
                column: "ShowingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Booking");

            migrationBuilder.DropTable(
                name: "BookingType");
        }
    }
}
