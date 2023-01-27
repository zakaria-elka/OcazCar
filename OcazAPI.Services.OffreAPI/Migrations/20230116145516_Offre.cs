using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OcazAPI.Services.OffreAPI.Migrations
{
    /// <inheritdoc />
    public partial class Offre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offres",
                columns: table => new
                {
                    OffreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OffreCarName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    DatePub = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ville = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentId = table.Column<int>(type: "int", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offres", x => x.OffreId);
                });

            migrationBuilder.InsertData(
                table: "Offres",
                columns: new[] { "OffreId", "AgentId", "CarId", "DatePub", "OffreCarName", "Price", "Ville" },
                values: new object[,]
                {
                    { 1, 1, 1, "12 janvier 2022", "Bwm Serie3 2012", 150000.0, "Rabat" },
                    { 2, 2, 2, "13 fevrier 2022 ", "Toyota corolla 2015", 100000.0, "Casablanca" },
                    { 3, 3, 3, "20 septembre 2022 ", "Hyundai tucson 2016", 170000.0, "Oujda" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Offres");
        }
    }
}
