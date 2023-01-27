using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OcazAPI.Services.AgentAPI.Migrations
{
    /// <inheritdoc />
    public partial class Agent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Agents",
                columns: table => new
                {
                    AgentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AgentName = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    AgentPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgentPas = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agents", x => x.AgentId);
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "AgentId", "AgentName", "AgentPas", "AgentPhone" },
                values: new object[,]
                {
                    { 1, "AZIZ", "1234", "0633445566" },
                    { 2, "Ahmed", "1234", "0633445588" },
                    { 3, "Said", "1234", "0633445577" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agents");
        }
    }
}
