using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Employee.Migrations
{
    /// <inheritdoc />
    public partial class CreateModels : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeTable",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTable", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "jobDescriptionTable",
                columns: table => new
                {
                    JobDescriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobDescriptionTable", x => x.JobDescriptionId);
                    table.ForeignKey(
                        name: "FK_jobDescriptionTable_EmployeeTable_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "EmployeeTable",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "jobTitleTable",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescriptionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobTitleTable", x => x.JobTitleId);
                    table.ForeignKey(
                        name: "FK_jobTitleTable_jobDescriptionTable_JobDescriptionId",
                        column: x => x.JobDescriptionId,
                        principalTable: "jobDescriptionTable",
                        principalColumn: "JobDescriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_jobDescriptionTable_EmployeeId",
                table: "jobDescriptionTable",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_jobTitleTable_JobDescriptionId",
                table: "jobTitleTable",
                column: "JobDescriptionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "jobTitleTable");

            migrationBuilder.DropTable(
                name: "jobDescriptionTable");

            migrationBuilder.DropTable(
                name: "EmployeeTable");
        }
    }
}
