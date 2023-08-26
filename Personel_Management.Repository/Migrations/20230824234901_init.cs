using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Personel_Management.Repository.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeHours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Start = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    End = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeHours", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Lastname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false, defaultValue: 18),
                    EmployeeHoursId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    isDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_EmployeeHours_EmployeeHoursId",
                        column: x => x.EmployeeHoursId,
                        principalTable: "EmployeeHours",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5495), null, "IT", null, false },
                    { 2, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5508), null, "HR", null, false },
                    { 3, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5509), null, "Management", null, false }
                });

            migrationBuilder.InsertData(
                table: "EmployeeHours",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "EmployeeId", "End", "Start", "UpdatedDate", "isDeleted" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5669), null, 1, "14:00", "08:00", null, false },
                    { 2, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5671), null, 2, "17:00", "08:00", null, false },
                    { 3, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5672), null, 3, "18:00", "09:00", null, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "CreatedDate", "DeletedDate", "DepartmentId", "EmployeeHoursId", "Lastname", "Name", "Password", "UpdatedDate", "UserName", "isDeleted" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5795), null, 1, 1, "Cabbar", "Ali", "password", null, "cabbar45", false },
                    { 2, 23, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5799), null, 2, 2, "Yıldırım", "Mahmut", "password", null, "mahmut45", false },
                    { 3, 22, new DateTime(2023, 8, 25, 2, 49, 1, 9, DateTimeKind.Local).AddTicks(5800), null, 2, 3, "Alkan", "Zeynep", "password", null, "alkan35", false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentId",
                table: "Employees",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_EmployeeHoursId",
                table: "Employees",
                column: "EmployeeHoursId",
                unique: true,
                filter: "[EmployeeHoursId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "EmployeeHours");
        }
    }
}
