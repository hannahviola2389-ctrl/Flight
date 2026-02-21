using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Flight.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FlightList",
                columns: table => new
                {
                    FlightListId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightNumber = table.Column<string>(type: "TEXT", nullable: false),
                    From = table.Column<string>(type: "TEXT", nullable: false),
                    To = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightList", x => x.FlightListId);
                });

            migrationBuilder.InsertData(
                table: "FlightList",
                columns: new[] { "FlightListId", "Date", "FlightNumber", "From", "Price", "To" },
                values: new object[,]
                {
                    { 1, "2026-03-10", "AA101", "New York", 350, "Chicago" },
                    { 2, "2026-03-12", "DL202", "Dallas", 420, "Los Angeles" },
                    { 3, "2026-03-15", "UA303", "Houston", 280, "Miami" },
                    { 4, "2026-03-18", "SW404", "Chicago", 300, "New York" },
                    { 5, "2026-03-20", "JB505", "Los Angeles", 390, "Dallas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightList");
        }
    }
}
