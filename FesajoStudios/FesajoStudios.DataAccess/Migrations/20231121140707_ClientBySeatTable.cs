using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ClientBySeatTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SeatXClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    SeatId = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeatXClient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SeatXClient_Client_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Client",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SeatXClient_Seat_SeatId",
                        column: x => x.SeatId,
                        principalTable: "Seat",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_SeatXClient_ClientId",
                table: "SeatXClient",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_SeatXClient_SeatId",
                table: "SeatXClient",
                column: "SeatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SeatXClient");
        }
    }
}
