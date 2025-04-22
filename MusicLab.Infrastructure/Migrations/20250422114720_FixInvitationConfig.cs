using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MusicLab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixInvitationConfig : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meetings_Members_MemberId",
                table: "Meetings");

            migrationBuilder.DropIndex(
                name: "IX_Meetings_MemberId",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "MemberId",
                table: "Meetings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                table: "Meetings",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1,
                column: "MemberId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 2,
                column: "MemberId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Meetings_MemberId",
                table: "Meetings",
                column: "MemberId");

            migrationBuilder.AddForeignKey(
                name: "FK_Meetings_Members_MemberId",
                table: "Meetings",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id");
        }
    }
}
