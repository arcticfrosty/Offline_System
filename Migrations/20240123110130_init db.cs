using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Offline_System.Migrations
{
    /// <inheritdoc />
    public partial class initdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContDepart",
                columns: table => new
                {
                    DepartId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContDepart", x => x.DepartId);
                });

            migrationBuilder.CreateTable(
                name: "ContEmployee",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContEmployee", x => x.EmployeesID);
                });

            migrationBuilder.CreateTable(
                name: "ContPos",
                columns: table => new
                {
                    PositionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContPos", x => x.PositionId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContDepart");

            migrationBuilder.DropTable(
                name: "ContEmployee");

            migrationBuilder.DropTable(
                name: "ContPos");
        }
    }
}
