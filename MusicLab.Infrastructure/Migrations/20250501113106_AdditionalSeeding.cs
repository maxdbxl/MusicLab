using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MusicLab.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "AICOM" },
                    { 3, "Compagnie Dalché" },
                    { 4, "Brussels Musical Creative" }
                });

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartTime",
                value: new DateTime(2025, 5, 14, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Meetings",
                columns: new[] { "Id", "Description", "EndTime", "EventType", "Location", "Name", "ProjectId", "StartTime" },
                values: new object[,]
                {
                    { 3, "Travail sur la mise en scène de l'acte 2", new DateTime(2025, 5, 14, 17, 30, 0, 0, DateTimeKind.Unspecified), 0, "Salle Polyvalente", "Atelier mise en scène", 1, new DateTime(2025, 5, 14, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Répétition complète avec costumes et décors", new DateTime(2025, 5, 18, 22, 0, 0, 0, DateTimeKind.Unspecified), 0, "Théâtre Municipal", "Répétition générale", 1, new DateTime(2025, 5, 18, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Sélection pour les seconds rôles", new DateTime(2025, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 5, "Studio 1", "Auditions complémentaires", 1, new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Première représentation de la comédie musicale", new DateTime(2025, 5, 24, 23, 0, 0, 0, DateTimeKind.Unspecified), 1, "Théâtre de la Ville", "Représentation publique", 1, new DateTime(2025, 5, 24, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Présentation du budget, point sur les sponsors et choix des affiches", new DateTime(2025, 5, 15, 23, 0, 0, 0, DateTimeKind.Unspecified), 2, "Salle B3", "Réunion Budget & Communication", 1, new DateTime(2025, 5, 15, 20, 30, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Visite coulisses & scène, vérification matos", new DateTime(2025, 5, 15, 17, 30, 0, 0, DateTimeKind.Unspecified), 3, "Théâtre de la Ville", "Rencontre de l'équipe technique", 1, new DateTime(2025, 5, 15, 15, 30, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "Username",
                value: "Mireille");

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Email", "Password", "Role", "Salt", "Username" },
                values: new object[,]
                {
                    { 3, "jeanine@branche.be", "^�<��d�rS!�a�<�4���G�Դ��[A���~���5�9�tiK����@�pu �'�\"�$", 0, new Guid("93f1883a-2735-4595-adbc-059acb879af6"), "Jeanine" },
                    { 4, "colette@branche.be", "C��x��O|5����nZ�(�d��M��Bӏ)oW��7Ń�i}�jn�5��u�R�pS�m]���", 0, new Guid("93f1883a-2735-4595-adbc-059acb879af6"), "Colette" },
                    { 5, "lison@branche.be", "k�p��3�����_�e<&�\\�C�`;�7%=�A����a1M���]*�Vv,̯54N��s�BEZ�", 0, new Guid("93f1883a-2735-4595-adbc-059acb879af6"), "Lison" }
                });

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Remplacement Gaby", "Boutique Louise", "Palais des thés" });

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "Resto fin des exams", "Nona Mérode", "Resto AICOM" });

            migrationBuilder.InsertData(
                table: "PersonalEvents",
                columns: new[] { "Id", "Description", "EndTime", "EventType", "Location", "MemberId", "Name", "StartTime" },
                values: new object[] { 3, "Resto fin des exams", new DateTime(2025, 5, 12, 22, 30, 0, 0, DateTimeKind.Unspecified), 4, "Nona Mérode", 2, "Resto AICOM", new DateTime(2025, 5, 12, 21, 15, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "EndDate", "Name", "OwnerId", "StartDate", "UpdateDate" },
                values: new object[,]
                {
                    { 2, new DateTime(2025, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chicago", 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2025, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Book of Mormon", 1, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Meetings",
                keyColumn: "Id",
                keyValue: 1,
                column: "StartTime",
                value: new DateTime(2025, 5, 11, 18, 30, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Members",
                keyColumn: "Id",
                keyValue: 2,
                column: "Username",
                value: "Mireillle");

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "", "Palais des thés", "Travail PDT" });

            migrationBuilder.UpdateData(
                table: "PersonalEvents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Location", "Name" },
                values: new object[] { "", "Nona", "Resto" });
        }
    }
}
