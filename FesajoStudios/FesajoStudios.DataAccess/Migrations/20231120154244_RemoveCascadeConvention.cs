using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class RemoveCascadeConvention : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BookingType_BookingTypeId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Showing_ShowingId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ClientType_ClientTypeId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_SeatType_SeatTypeId",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Showing_ShowingId",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Theather_TheatherId",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Showing_ShowingId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketType_TicketTypeId",
                table: "Ticket");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BookingType_BookingTypeId",
                table: "Booking",
                column: "BookingTypeId",
                principalTable: "BookingType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Showing_ShowingId",
                table: "Booking",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ClientType_ClientTypeId",
                table: "Client",
                column: "ClientTypeId",
                principalTable: "ClientType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_SeatType_SeatTypeId",
                table: "Seat",
                column: "SeatTypeId",
                principalTable: "SeatType",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Showing_ShowingId",
                table: "Seat",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Theather_TheatherId",
                table: "Showing",
                column: "TheatherId",
                principalTable: "Theather",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Showing_ShowingId",
                table: "Ticket",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketType_TicketTypeId",
                table: "Ticket",
                column: "TicketTypeId",
                principalTable: "TicketType",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Booking_BookingType_BookingTypeId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Booking_Showing_ShowingId",
                table: "Booking");

            migrationBuilder.DropForeignKey(
                name: "FK_Client_ClientType_ClientTypeId",
                table: "Client");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_SeatType_SeatTypeId",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Showing_ShowingId",
                table: "Seat");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Showing_Theather_TheatherId",
                table: "Showing");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_Showing_ShowingId",
                table: "Ticket");

            migrationBuilder.DropForeignKey(
                name: "FK_Ticket_TicketType_TicketTypeId",
                table: "Ticket");

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_BookingType_BookingTypeId",
                table: "Booking",
                column: "BookingTypeId",
                principalTable: "BookingType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Client_ClientId",
                table: "Booking",
                column: "ClientId",
                principalTable: "Client",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Booking_Showing_ShowingId",
                table: "Booking",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Client_ClientType_ClientTypeId",
                table: "Client",
                column: "ClientTypeId",
                principalTable: "ClientType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_SeatType_SeatTypeId",
                table: "Seat",
                column: "SeatTypeId",
                principalTable: "SeatType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Showing_ShowingId",
                table: "Seat",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Movie_MovieId",
                table: "Showing",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Showing_Theather_TheatherId",
                table: "Showing",
                column: "TheatherId",
                principalTable: "Theather",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_Showing_ShowingId",
                table: "Ticket",
                column: "ShowingId",
                principalTable: "Showing",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ticket_TicketType_TicketTypeId",
                table: "Ticket",
                column: "TicketTypeId",
                principalTable: "TicketType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
