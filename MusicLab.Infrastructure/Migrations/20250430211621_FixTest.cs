using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventType",
                value: 4);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 1,
                column: "EventType",
                value: 5);

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 2,
                column: "EventType",
                value: 5);
        }
    }
}
