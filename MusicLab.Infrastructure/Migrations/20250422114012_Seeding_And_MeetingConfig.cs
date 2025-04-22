using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seeding_And_MeetingConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Members_MemberId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_MemberId",
                table: "Projects");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Projects",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EndDate", "Name", "OwnerId", "StartDate", "UpdateDate" },
                values: new object[] { 1, new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dear Evan Hansen", 1, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Description", "EndTime", "Location", "MemberId", "Name", "ProjectId", "StartTime" },
                values: new object[,]
                {
                    { 1, "répétition chorégraphie, amenez vos chaussures", new DateTime(2025, 5, 11, 21, 0, 0, 0, DateTimeKind.Unspecified), "Local C1", null, "Répétition du mercredi", 1, new DateTime(2025, 5, 11, 18, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "répétition chant", new DateTime(2025, 5, 12, 21, 0, 0, 0, DateTimeKind.Unspecified), "Local B3", null, "Répétition du jeudi", 1, new DateTime(2025, 5, 12, 18, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects",
                column: "OwnerId"
                );

            migrationBuilder.AddCheckConstraint(
                name: "CK_CompareDates",
                table: "Projects",
                sql: "startDate < endDate");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Members_OwnerId",
                table: "Projects",
                column: "OwnerId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Projects_Members_OwnerId",
                table: "Projects");

            migrationBuilder.DropIndex(
                name: "IX_Projects_OwnerId",
                table: "Projects");

            migrationBuilder.DropCheckConstraint(
                name: "CK_CompareDates",
                table: "Projects");

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Projects");

            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Projects",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Projects_MemberId",
                table: "Projects",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Projects_Members_MemberId",
                table: "Projects",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id");
        }
    }
}
