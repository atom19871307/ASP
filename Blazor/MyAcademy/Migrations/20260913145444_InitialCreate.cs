using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyAcademy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Directions",
                columns: table => new
                {
                    direction_id = table.Column<byte>(type: "tinyint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    direction_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directions", x => x.direction_id);
                });

            migrationBuilder.CreateTable(
                name: "Disciplines",
                columns: table => new
                {
                    discipline_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    discipline_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    number_of_lessons = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disciplines", x => x.discipline_id);
                });

            migrationBuilder.CreateTable(
                name: "Teachers",
                columns: table => new
                {
                    teacher_id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    middle_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    birth_date = table.Column<DateOnly>(type: "date", nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    work_since = table.Column<DateOnly>(type: "date", nullable: true),
                    rate = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teachers", x => x.teacher_id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    group_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    group_name = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    direction = table.Column<byte>(type: "tinyint", nullable: true),
                    start_date = table.Column<DateOnly>(type: "date", nullable: true),
                    start_time = table.Column<TimeOnly>(type: "time", nullable: true),
                    learning_days = table.Column<byte>(type: "tinyint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.group_id);
                    table.ForeignKey(
                        name: "FK_Groups_Directions_direction",
                        column: x => x.direction,
                        principalTable: "Directions",
                        principalColumn: "direction_id");
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    stud_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    last_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    first_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    middle_name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    birth_date = table.Column<DateOnly>(type: "date", nullable: true),
                    email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    phone = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    photo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    group = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.stud_id);
                    table.ForeignKey(
                        name: "FK_Students_Groups_group",
                        column: x => x.group,
                        principalTable: "Groups",
                        principalColumn: "group_id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Groups_direction",
                table: "Groups",
                column: "direction");

            migrationBuilder.CreateIndex(
                name: "IX_Students_group",
                table: "Students",
                column: "group");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disciplines");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Teachers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "Directions");
        }
    }
}
