using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagment.Server.Data.Migrations
{
    public partial class SeededDefaultCarData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 28, 16, 18, 30, 329, DateTimeKind.Local).AddTicks(2420), new DateTime(2021, 10, 28, 16, 18, 30, 331, DateTimeKind.Local).AddTicks(6795), "Black", "System" },
                    { 2, "System", new DateTime(2021, 10, 28, 16, 18, 30, 331, DateTimeKind.Local).AddTicks(7397), new DateTime(2021, 10, 28, 16, 18, 30, 331, DateTimeKind.Local).AddTicks(7405), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7652), new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7691), "Toyota", "System" },
                    { 2, "System", new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7910), new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7915), "BMW", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(884), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(903), "Prius", "System" },
                    { 2, "System", new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1108), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1112), "Vitz", "System" },
                    { 3, "System", new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1115), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1118), "3 Series", "System" },
                    { 4, "System", new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1120), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1123), "X5", "System" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
