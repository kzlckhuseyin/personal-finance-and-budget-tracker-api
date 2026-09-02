using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personal_finance_and_budget_tracker_api.Migrations
{
    /// <inheritdoc />
    public partial class FixStaticSeederValues : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "PasswordHash" },
                values: new object[,]
                {
                    { 10, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Alpsalci.Atan@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 11, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bulus76@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 12, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Atalan38@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 13, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Baysungur_Akal39@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 14, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Aladag_Sayginer4@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 15, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Alptutuk_Catalbas18@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 16, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Aydogan.Koyluoglu53@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 17, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Buyat2@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 18, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Burkek24@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" },
                    { 19, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Avsar4@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2e7/G6YxO3c4P3K2Q9m9u.eD.fW4xQ1mS" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);
        }
    }
}
