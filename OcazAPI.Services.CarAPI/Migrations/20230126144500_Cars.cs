using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OcazAPI.Services.CarAPI.Migrations
{
    /// <inheritdoc />
    public partial class Cars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    CarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CarModel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarTrans = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarCarburant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarKm = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarDesc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarImage = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.CarId);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "CarId", "CarCarburant", "CarDesc", "CarImage", "CarKm", "CarModel", "CarName", "CarTrans" },
                values: new object[,]
                {
                    { 1, "Essence", "4cylindre 2l avec 200hp 320Nm", new byte[0], "100 000km", "2012", "Bwm Serie3", "Automatique" },
                    { 2, "Diesel", "4cylindre 1.2l avec 120hp 300Nm", new byte[0], "120 000km", "2015", "Toyota corolla", "Manuel" },
                    { 3, "Diesel", "4cylindre 1.6l avec 160hp 320Nm", new byte[0], "95 520km", "2016", "Hyundai tucson", "Manuel" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
