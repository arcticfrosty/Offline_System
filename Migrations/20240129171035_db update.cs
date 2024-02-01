using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Offline_System.Migrations
{
    /// <inheritdoc />
    public partial class dbupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OS_Departments",
                columns: table => new
                {
                    DepartID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS_Departments", x => x.DepartID);
                });

            migrationBuilder.CreateTable(
                name: "OS_Employees",
                columns: table => new
                {
                    EmployeesID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeesName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeGender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeAge = table.Column<int>(type: "int", nullable: false),
                    EmployeeDoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeePosition = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeDeparment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS_Employees", x => x.EmployeesID);
                });

            migrationBuilder.CreateTable(
                name: "OS_Positions",
                columns: table => new
                {
                    PositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PositionDepart = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OS_Positions", x => x.PositionID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OS_Departments");

            migrationBuilder.DropTable(
                name: "OS_Employees");

            migrationBuilder.DropTable(
                name: "OS_Positions");
        }
    }
}
