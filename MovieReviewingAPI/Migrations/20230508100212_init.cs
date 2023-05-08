using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovieReviewingAPI.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieDatas",
                columns: table => new
                {
                    MovieName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RatingonIMD = table.Column<float>(type: "real", nullable: false),
                    MovieDesc = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieDatas", x => x.MovieName);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieDatas");
        }
    }
}
