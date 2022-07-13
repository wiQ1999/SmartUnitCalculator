using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartUnitCalculator.Migrations
{
    public partial class AddBasicSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UnitTypes",
                columns: new[] { "Name", "Priority" },
                values: new object[,]
                {
                    { "Czas", 50 },
                    { "Długość", 20 },
                    { "Objętość", 30 },
                    { "Temperatura", 40 },
                    { "Waga", 10 }
                });

            migrationBuilder.InsertData(
                table: "Units",
                columns: new[] { "Id", "Name", "Priority", "Symbol", "TypeName" },
                values: new object[,]
                {
                    { 1, "miligram", 10, "mg", "Waga" },
                    { 2, "gram", 20, "g", "Waga" },
                    { 3, "dekagram", 30, "dag", "Waga" },
                    { 4, "kilogram", 40, "kg", "Waga" },
                    { 5, "tona", 50, "t", "Waga" },
                    { 6, "milimetr", 10, "mm", "Długość" },
                    { 7, "centrymetr", 20, "cm", "Długość" },
                    { 8, "decymetr", 30, "dm", "Długość" },
                    { 9, "metr", 40, "m", "Długość" },
                    { 10, "kilometr", 50, "km", "Objętość" },
                    { 11, "pikolitr", 10, "pl", "Objętość" },
                    { 12, "mililitr", 20, "ml", "Objętość" },
                    { 13, "litr", 30, "l", "Objętość" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "Name",
                keyValue: "Czas");

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "Name",
                keyValue: "Temperatura");

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "Name",
                keyValue: "Długość");

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "Name",
                keyValue: "Objętość");

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "Name",
                keyValue: "Waga");
        }
    }
}
