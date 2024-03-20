using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace do_an_Travel_Backend.Migrations
{
    public partial class init_travel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "travel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsComplete = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travel", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "travel",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Ahihi" });

            migrationBuilder.InsertData(
                table: "travel",
                columns: new[] { "Id", "Name" },
                values: new object[] { 2, "Ahihi2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "travel");
        }
    }
}
