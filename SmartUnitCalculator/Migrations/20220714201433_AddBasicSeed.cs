using System;
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
                    { "Długość", 20 },
                    { "Objętość", 30 },
                    { "Pamięć", 40 },
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
                    { 10, "kilometr", 50, "km", "Długość" },
                    { 11, "pikolitr", 10, "pl", "Objętość" },
                    { 12, "mililitr", 20, "ml", "Objętość" },
                    { 13, "litr", 30, "l", "Objętość" },
                    { 14, "bit", 10, "b", "Pamięć" },
                    { 15, "bajt", 20, "B", "Pamięć" },
                    { 16, "kilobit", 30, "Kb", "Pamięć" },
                    { 17, "kilobajt", 40, "KB", "Pamięć" },
                    { 18, "maegabit", 50, "Mb", "Pamięć" },
                    { 19, "megabajt", 60, "MB", "Pamięć" },
                    { 20, "gigabit", 70, "Gb", "Pamięć" },
                    { 21, "gigabajt", 80, "GB", "Pamięć" },
                    { 22, "terabit", 90, "Tb", "Pamięć" },
                    { 23, "terabajt", 100, "TB", "Pamięć" }
                });

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
                    { 20, 5, 1000m, 4 },
                    { 21, 6, 0.1m, 7 },
                    { 22, 6, 0.01m, 8 },
                    { 23, 6, 0.001m, 9 },
                    { 24, 6, 0.000001m, 10 },
                    { 25, 7, 10m, 6 },
                    { 26, 7, 0.1m, 8 },
                    { 27, 7, 0.01m, 9 },
                    { 28, 7, 0.00001m, 10 },
                    { 29, 8, 100m, 6 },
                    { 30, 8, 10m, 7 },
                    { 31, 8, 0.1m, 9 },
                    { 32, 8, 0.0001m, 10 },
                    { 33, 9, 1000m, 6 },
                    { 34, 9, 100m, 7 },
                    { 35, 9, 10m, 8 },
                    { 36, 9, 0.001m, 10 },
                    { 37, 10, 1000000m, 6 },
                    { 38, 10, 100000m, 7 },
                    { 39, 10, 10000m, 8 },
                    { 40, 10, 1000m, 9 },
                    { 41, 11, 0.000000001m, 12 },
                    { 42, 11, 0.000000000001m, 13 }
                });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "BaseUnitId", "Multiplier", "ResultUnitId" },
                values: new object[,]
                {
                    { 43, 12, 1000000000m, 11 },
                    { 44, 12, 0.001m, 13 },
                    { 45, 13, 1000000000000m, 11 },
                    { 46, 13, 1000m, 12 },
                    { 47, 14, 0.125m, 15 },
                    { 48, 14, 0.001m, 16 },
                    { 49, 14, 0.000125m, 17 },
                    { 50, 14, 0.000001m, 18 },
                    { 51, 14, 0.000000125m, 19 },
                    { 52, 14, 0.000000001m, 20 },
                    { 53, 14, 0.000000000125m, 21 },
                    { 54, 14, 0.000000000001m, 22 },
                    { 55, 14, 0.000000000000125m, 23 },
                    { 56, 15, 8m, 14 },
                    { 57, 15, 0.008m, 16 },
                    { 58, 15, 0.001m, 17 },
                    { 59, 15, 0.000008m, 18 },
                    { 60, 15, 0.000001m, 19 },
                    { 61, 15, 0.000000008m, 20 },
                    { 62, 15, 0.000000001m, 21 },
                    { 63, 15, 0.000000000008m, 22 },
                    { 64, 15, 0.000000000001m, 23 },
                    { 65, 16, 1000m, 14 },
                    { 66, 16, 125m, 15 },
                    { 67, 16, 0.125m, 17 },
                    { 68, 16, 0.001m, 18 },
                    { 69, 16, 0.000125m, 19 },
                    { 70, 16, 0.000001m, 20 },
                    { 71, 16, 0.000000125m, 21 },
                    { 72, 16, 0.000000001m, 22 },
                    { 73, 16, 0.000000000125m, 23 },
                    { 74, 17, 8000m, 14 },
                    { 75, 17, 1000m, 15 },
                    { 76, 17, 8m, 16 },
                    { 77, 17, 0.008m, 18 },
                    { 78, 17, 0.001m, 19 },
                    { 79, 17, 0.000008m, 20 },
                    { 80, 17, 0.000001m, 21 },
                    { 81, 17, 0.000000008m, 22 },
                    { 82, 17, 0.000000001m, 23 },
                    { 83, 18, 1000000m, 14 },
                    { 84, 18, 125000m, 15 }
                });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "BaseUnitId", "Multiplier", "ResultUnitId" },
                values: new object[,]
                {
                    { 85, 18, 1000m, 16 },
                    { 86, 18, 125m, 17 },
                    { 87, 18, 0.125m, 19 },
                    { 88, 18, 0.001m, 20 },
                    { 89, 18, 0.000125m, 21 },
                    { 90, 18, 0.000001m, 22 },
                    { 91, 18, 0.000000125m, 23 },
                    { 92, 19, 8000000m, 14 },
                    { 93, 19, 1000000m, 15 },
                    { 94, 19, 8000m, 16 },
                    { 95, 19, 1000m, 17 },
                    { 96, 19, 8m, 18 },
                    { 97, 19, 0.008m, 20 },
                    { 98, 19, 0.001m, 21 },
                    { 99, 19, 0.000008m, 22 },
                    { 100, 19, 0.000001m, 23 },
                    { 101, 20, 1000000000m, 14 },
                    { 102, 20, 125000000m, 15 },
                    { 103, 20, 1000000m, 16 },
                    { 104, 20, 125000m, 17 },
                    { 105, 20, 1000m, 18 },
                    { 106, 20, 125m, 19 },
                    { 107, 20, 0.125m, 21 },
                    { 108, 20, 0.001m, 22 },
                    { 109, 20, 0.000125m, 23 },
                    { 110, 21, 8000000000m, 14 },
                    { 111, 21, 1000000000m, 15 },
                    { 112, 21, 8000000m, 16 },
                    { 113, 21, 1000000m, 17 },
                    { 114, 21, 8000m, 18 },
                    { 115, 21, 1000m, 19 },
                    { 116, 21, 8m, 20 },
                    { 117, 21, 0.008m, 22 },
                    { 118, 21, 0.001m, 23 },
                    { 119, 22, 1000000000000m, 14 },
                    { 120, 22, 125000000000m, 15 },
                    { 121, 22, 10000000000m, 16 },
                    { 122, 22, 125000000m, 17 },
                    { 123, 22, 1000000m, 18 },
                    { 124, 22, 125000m, 19 },
                    { 125, 22, 1000m, 20 },
                    { 126, 22, 125m, 21 }
                });

            migrationBuilder.InsertData(
                table: "Calculations",
                columns: new[] { "Id", "BaseUnitId", "Multiplier", "ResultUnitId" },
                values: new object[,]
                {
                    { 127, 22, 0.125m, 23 },
                    { 128, 23, 8000000000000m, 14 },
                    { 129, 23, 1000000000000m, 15 },
                    { 130, 23, 8000000000m, 16 },
                    { 131, 23, 1000000000m, 17 },
                    { 132, 23, 8000000m, 18 },
                    { 133, 23, 1000000m, 19 },
                    { 134, 23, 8000m, 20 },
                    { 135, 23, 1000m, 21 },
                    { 136, 23, 8m, 22 }
                });

            migrationBuilder.InsertData(
                table: "History",
                columns: new[] { "Id", "BaseUnitId", "BaseValue", "Created", "ResultUnitId", "ResultValue" },
                values: new object[,]
                {
                    { 1, 3, 25m, new DateTime(2022, 7, 2, 12, 51, 2, 0, DateTimeKind.Unspecified), 5, 0.00025m },
                    { 2, 3, 25m, new DateTime(2022, 7, 2, 12, 51, 59, 0, DateTimeKind.Unspecified), 4, 0.25m },
                    { 3, 4, 1m, new DateTime(2022, 7, 3, 9, 30, 51, 0, DateTimeKind.Unspecified), 2, 1000m },
                    { 4, 4, 1.24m, new DateTime(2022, 7, 4, 21, 11, 21, 0, DateTimeKind.Unspecified), 2, 1240m }
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
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Calculations",
                keyColumn: "Id",
                keyValue: 136);

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
                table: "History",
                keyColumn: "Id",
                keyValue: 4);

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

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Units",
                keyColumn: "Id",
                keyValue: 23);

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
                keyValue: "Pamięć");

            migrationBuilder.DeleteData(
                table: "UnitTypes",
                keyColumn: "Name",
                keyValue: "Waga");
        }
    }
}
