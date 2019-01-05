using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookService.WebAPI.Migrations
{
    public partial class ddd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Reader",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Rating",
                nullable: true,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 5, 20, 31, 30, 433, DateTimeKind.Local), "James", "Sharp" },
                    { 2, new DateTime(1992, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 5, 20, 31, 30, 433, DateTimeKind.Local), "Sophie", "Netty" },
                    { 3, new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 5, 20, 31, 30, 433, DateTimeKind.Local), "Elisa", "Yammy" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Country", "Created", "Name" },
                values: new object[,]
                {
                    { 1, "UK", new DateTime(2019, 1, 5, 20, 31, 30, 474, DateTimeKind.Local), "IT-publishers" },
                    { 2, "Sweden", new DateTime(2019, 1, 5, 20, 31, 30, 474, DateTimeKind.Local), "FoodBooks" }
                });

            migrationBuilder.InsertData(
                table: "Reader",
                columns: new[] { "Id", "Created", "FirstName", "Lastname" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 1, 5, 20, 31, 30, 490, DateTimeKind.Local), "Ruthje", "VanderBeken" },
                    { 2, new DateTime(2019, 1, 5, 20, 31, 30, 490, DateTimeKind.Local), "Noëlla", "Snauwaert" },
                    { 3, new DateTime(2019, 1, 5, 20, 31, 30, 490, DateTimeKind.Local), "Bart", "Sompsin" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Created", "FileName", "ISBN", "NumberOfPages", "Price", "PublisherId", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book1.jpg", "123456789", 420, 24.99m, 1, "Learning C#", 2018 },
                    { 2, 2, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book2.jpg", "45689132", 360, 35.99m, 1, "Mastering Linq", 2016 },
                    { 3, 1, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book3.jpg", "15856135", 360, 50.00m, 1, "Mastering Xamarin", 2017 },
                    { 4, 2, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book1.jpg", "56789564", 360, 45.00m, 1, "Exploring ASP.Net Core 2.0", 2018 },
                    { 5, 2, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book2.jpg", "234546684", 420, 70.50m, 1, "Unity Game Development", 2017 },
                    { 6, 3, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book3.jpg", "789456258", 40, 52.00m, 2, "Cooking is fun", 2007 },
                    { 7, 3, new DateTime(2019, 1, 5, 20, 31, 30, 592, DateTimeKind.Local), "book1.jpg", "94521546", 53, 30.00m, 2, "Secret recipes", 2017 }
                });

            migrationBuilder.InsertData(
                table: "Rating",
                columns: new[] { "Id", "BookId", "Created", "ReaderId", "Score" },
                values: new object[,]
                {
                    { 5, 1, new DateTime(2019, 1, 5, 20, 31, 30, 482, DateTimeKind.Local), 1, 5 },
                    { 2, 2, new DateTime(2019, 1, 5, 20, 31, 30, 482, DateTimeKind.Local), 3, 4 },
                    { 3, 3, new DateTime(2019, 1, 5, 20, 31, 30, 482, DateTimeKind.Local), 1, 1 },
                    { 4, 3, new DateTime(2019, 1, 5, 20, 31, 30, 482, DateTimeKind.Local), 3, 3 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Rating",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Book",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reader",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Publisher",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Reader",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Created",
                table: "Rating",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true,
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.InsertData(
                table: "Author",
                columns: new[] { "Id", "BirthDate", "Created", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, new DateTime(1980, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 5, 18, 25, 27, 94, DateTimeKind.Local), "James", "Sharp" },
                    { 2, new DateTime(1992, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 5, 18, 25, 27, 94, DateTimeKind.Local), "Sophie", "Netty" },
                    { 3, new DateTime(1996, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 1, 5, 18, 25, 27, 94, DateTimeKind.Local), "Elisa", "Yammy" }
                });

            migrationBuilder.InsertData(
                table: "Publisher",
                columns: new[] { "Id", "Country", "Created", "Name" },
                values: new object[,]
                {
                    { 1, "UK", new DateTime(2019, 1, 5, 18, 25, 27, 95, DateTimeKind.Local), "IT-publishers" },
                    { 2, "Sweden", new DateTime(2019, 1, 5, 18, 25, 27, 95, DateTimeKind.Local), "FoodBooks" }
                });

            migrationBuilder.InsertData(
                table: "Book",
                columns: new[] { "Id", "AuthorId", "Created", "FileName", "ISBN", "NumberOfPages", "Price", "PublisherId", "Title", "Year" },
                values: new object[,]
                {
                    { 1, 1, null, "book1.jpg", "123456789", 420, 24.99m, 1, "Learning C#", 2018 },
                    { 2, 2, null, "book2.jpg", "45689132", 360, 35.99m, 1, "Mastering Linq", 2016 },
                    { 3, 1, null, "book3.jpg", "15856135", 360, 50.00m, 1, "Mastering Xamarin", 2017 },
                    { 4, 2, null, "book1.jpg", "56789564", 360, 45.00m, 1, "Exploring ASP.Net Core 2.0", 2018 },
                    { 5, 2, null, "book2.jpg", "234546684", 420, 70.50m, 1, "Unity Game Development", 2017 },
                    { 6, 3, null, "book3.jpg", "789456258", 40, 52.00m, 2, "Cooking is fun", 2007 },
                    { 7, 3, null, "book1.jpg", "94521546", 53, 30.00m, 2, "Secret recipes", 2017 }
                });
        }
    }
}
