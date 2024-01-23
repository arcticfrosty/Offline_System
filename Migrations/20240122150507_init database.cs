using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Offline_System.Migrations {
    /// <inheritdoc />
    public partial class initdatabase : Migration {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new {
                    departId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    departName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    departActive = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table => {
                    table.PrimaryKey("PK_departments", x => x.departId);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new {
                    EmployeesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table => {
                    table.PrimaryKey("PK_employees", x => x.EmployeesID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder) {
            migrationBuilder.DropTable(
                name: "departments");

            migrationBuilder.DropTable(
                name: "employees");
        }
    }
}
