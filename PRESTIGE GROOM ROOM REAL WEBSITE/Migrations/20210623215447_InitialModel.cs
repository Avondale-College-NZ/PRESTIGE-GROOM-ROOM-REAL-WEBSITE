using Microsoft.EntityFrameworkCore.Migrations;

namespace PRESTIGE_GROOM_ROOM_REAL_WEBSITE.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staffs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Experience = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    ProfilePicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staffs", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staffs");
        }
    }
}
