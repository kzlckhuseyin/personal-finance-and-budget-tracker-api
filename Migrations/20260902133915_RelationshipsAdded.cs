using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace personal_finance_and_budget_tracker_api.Migrations
{
    /// <inheritdoc />
    public partial class RelationshipsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Categories",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Beauty", "gelir", 17 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Clothing", "gider", 15 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Shoes", "gelir", 17 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Beauty", "gelir", 21 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Type", "UserId" },
                values: new object[] { "gider", 11 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Jewelery", "gider", 21 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "UserId" },
                values: new object[] { "Games", 31 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Jewelery", "gider", 11 });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Type", "UserId" },
                values: new object[] { "Clothing", "gelir", 37 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Type", "UserId" },
                values: new object[,]
                {
                    { 20, "Clothing", "gider", 15 },
                    { 24, "Games", "gelir", 11 },
                    { 25, "Jewelery", "gider", 13 },
                    { 26, "Computers", "gider", 18 },
                    { 27, "Baby", "gelir", 11 },
                    { 28, "Kids", "gider", 11 },
                    { 32, "Movies", "gelir", 10 },
                    { 35, "Books", "gelir", 11 },
                    { 40, "Beauty", "gelir", 18 },
                    { 43, "Garden", "gider", 14 },
                    { 44, "Music", "gelir", 19 },
                    { 45, "Jewelery", "gelir", 14 },
                    { 49, "Industrial", "gider", 10 },
                    { 50, "Garden", "gider", 10 },
                    { 51, "Electronics", "gelir", 11 },
                    { 53, "Music", "gider", 13 },
                    { 54, "Music", "gelir", 19 },
                    { 55, "Shoes", "gider", 10 },
                    { 59, "Kids", "gelir", 18 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "Email", "PasswordHash" },
                values: new object[,]
                {
                    { 20, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bayruk_Akaydin@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 21, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Arsal.Aclan@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 22, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bulmaz.Akman@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 23, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Barskan.Koyuncu@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 24, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Abluc65@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 25, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Gunes.Cevik@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 26, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Agalak43@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 27, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Beg90@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 28, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Burulday_Adal33@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 29, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Altinkagan.Alyanak@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 30, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Alptutuk59@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 31, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kimizin_Tekand28@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 32, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Kimizalmila34@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 33, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Adberilgen3@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 34, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Berkis99@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 35, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Alkaevli75@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 36, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Abay_Akar23@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 37, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Edil_Dogan@hotmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 38, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Aral2@yahoo.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" },
                    { 39, new DateTime(2026, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Isik.Ozkok88@gmail.com", "$2a$11$e8S.s/Hw.NnU1yZk5fJp2eZS1xJSsk8ERtvmPyhUkYZrEi9LYzOYi" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Type", "UserId" },
                values: new object[,]
                {
                    { 21, "Books", "gelir", 27 },
                    { 22, "Sports", "gelir", 26 },
                    { 23, "Jewelery", "gider", 21 },
                    { 29, "Grocery", "gider", 28 },
                    { 30, "Electronics", "gelir", 20 },
                    { 31, "Computers", "gelir", 31 },
                    { 33, "Jewelery", "gelir", 25 },
                    { 34, "Health", "gelir", 34 },
                    { 36, "Baby", "gelir", 37 },
                    { 37, "Automotive", "gelir", 21 },
                    { 38, "Kids", "gelir", 21 },
                    { 39, "Games", "gelir", 33 },
                    { 41, "Outdoors", "gider", 32 },
                    { 42, "Books", "gider", 38 },
                    { 46, "Electronics", "gider", 25 },
                    { 47, "Industrial", "gider", 30 },
                    { 48, "Clothing", "gelir", 26 },
                    { 52, "Electronics", "gider", 22 },
                    { 56, "Books", "gider", 36 },
                    { 57, "Computers", "gider", 35 },
                    { 58, "Home", "gider", 29 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_CategoryId",
                table: "Transactions",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UserId",
                table: "Categories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UserId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Categories_CategoryId",
                table: "Transactions");

            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Users_UserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_CategoryId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Transactions_UserId",
                table: "Transactions");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UserId",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Categories");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Music", "gider" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Games", "gelir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Clothing", "gider" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Games", "gider" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                column: "Type",
                value: "gelir");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Beauty", "gelir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: "Tools");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Beauty", "gelir" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Type" },
                values: new object[] { "Jewelery", "gider" });
        }
    }
}
