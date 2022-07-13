using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartUnitCalculator.Migrations
{
    public partial class AddExtensionToSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "BaseUnitId", "Multiplier", "ResultUnitId" },
                values: new object[,]
                {
                    { 1, 1, 0.001m, 2 },
                    { 2, 1, 0.0001m, 3 },
                    { 3, 1, 0.000001m, 4 },
                    { 4, 1, 0.000000001m, 5 },
                    { 5, 2, 1000m, 1 },
                    { 6, 2, 0.1m, 3 },
                    { 7, 2, 0.001m, 4 },
                    { 8, 2, 0.000001m, 5 },
                    { 9, 3, 10000m, 1 },
                    { 10, 3, 10m, 2 },
                    { 11, 3, 0.01m, 4 },
                    { 12, 3, 0.00001m, 5 },
                    { 13, 4, 1000000m, 1 },
                    { 14, 4, 1000m, 2 },
                    { 15, 4, 100m, 3 },
                    { 16, 4, 0.001m, 5 },
                    { 17, 5, 1000000000m, 1 },
                    { 18, 5, 1000000m, 2 },
                    { 19, 5, 100000m, 3 },
                    { 20, 5, 1000m, 4 }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "Id", "BaseUnitId", "BaseValue", "Created", "ResultUnitId", "ResultValue" },
                values: new object[,]
                {
                    { 1, 3, 25m, new DateTime(2022, 7, 2, 12, 51, 2, 0, DateTimeKind.Unspecified), 5, 0.00025m },
                    { 2, 3, 25m, new DateTime(2022, 7, 2, 12, 51, 59, 0, DateTimeKind.Unspecified), 4, 0.25m },
                    { 3, 4, 1m, new DateTime(2022, 7, 3, 9, 30, 51, 0, DateTimeKind.Unspecified), 2, 1000m }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Name", "Priority", "Symbol", "TypeName" },
                values: new object[,]
                {
                    { 14, "Kelwin", 10, "K", "Temperatura" },
                    { 15, "Celsjusz", 20, "C", "Temperatura" },
                    { 16, "Fahrenheit", 30, "F", "Temperatura" },
                    { 17, "milisekunda", 10, "ms", "Czas" },
                    { 18, "sekunda", 20, "sek", "Czas" },
                    { 19, "minuta", 30, "min", "Czas" },
                    { 20, "godzina", 40, "h", "Czas" },
                    { 21, "doba", 50, "d", "Czas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "History",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 21);
        }
    }
}
