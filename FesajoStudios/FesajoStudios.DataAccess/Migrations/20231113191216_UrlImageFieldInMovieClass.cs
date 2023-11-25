using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FesajoStudios.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UrlImageFieldInMovieClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UrlImage",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UrlImage",
                table: "Movie");
        }
    }
}
