using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddingPersonalEventsToDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EventType",
                table: "Meetings",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PersonalEvents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventType = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalEvents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonalEvents_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventType",
                value: 1);

            migrationBuilder.InsertData(
                table: "PersonalEvents",
                columns: new[] { "Id", "Description", "EndTime", "EventType", "Location", "MemberId", "Name", "StartTime" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2025, 5, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), 5, "Palais des thés", 1, "Travail PDT", new DateTime(2025, 5, 12, 9, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2025, 5, 12, 22, 30, 0, 0, DateTimeKind.Unspecified), 5, "Nona", 1, "Resto", new DateTime(2025, 5, 12, 21, 15, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PersonalEvents_MemberId",
                table: "PersonalEvents",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonalEvents");

            migrationBuilder.DropColumn(
                name: "EventType",
                table: "Meetings");
        }
    }
}
