using Microsoft.EntityFrameworkCore.Migrations;

namespace RadioServer.Migrations.RadioDb
{
    public partial class scaffolding1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RadioStations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StationName = table.Column<string>(type: "TEXT", nullable: true),
                    StationUrl = table.Column<string>(type: "TEXT", nullable: true),
                    IconUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RadioStations", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RadioStations");
        }
    }
}
