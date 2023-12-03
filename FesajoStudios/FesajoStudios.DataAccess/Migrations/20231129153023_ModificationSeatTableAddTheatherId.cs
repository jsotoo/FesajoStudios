using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class ModificationSeatTableAddTheatherId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TheatherId",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Seat_TheatherId",
                table: "Seat",
                column: "TheatherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Theather_TheatherId",
                table: "Seat",
                column: "TheatherId",
                principalTable: "Theather",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Theather_TheatherId",
                table: "Seat");

            migrationBuilder.DropIndex(
                name: "IX_Seat_TheatherId",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "TheatherId",
                table: "Seat");
        }
    }
}
