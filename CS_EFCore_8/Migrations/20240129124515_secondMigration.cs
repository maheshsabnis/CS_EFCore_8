using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CS_EFCore_8.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BirthRecord",
                columns: table => new
                {
                    BirthId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BirthName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: false),
                    TimeOfBirth = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BirthRecord", x => x.BirthId);
                });

            migrationBuilder.InsertData(
                table: "BirthRecord",
                columns: new[] { "BirthId", "BirthName", "DateOfBirth", "TimeOfBirth" },
                values: new object[] { 1, "Ganesh", new DateOnly(2022, 1, 1), new TimeOnly(1, 0, 0) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BirthRecord");
        }
    }
}
