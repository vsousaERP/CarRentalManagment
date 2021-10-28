using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagment.Server.Data.Migrations
{
    public partial class SeededDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3b1478b3-e841-45b7-aae5-1e0c36dfb235", "3672074e-3c0c-46b3-939d-ad9682c68327", "User", "USER" },
                    { "b358313a-661f-4f10-bf7d-46b6db6d2f95", "d9459af1-ad8e-4604-9c38-ee59f01b7642", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 219, DateTimeKind.Local).AddTicks(3638), new DateTime(2021, 10, 28, 16, 28, 28, 222, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 222, DateTimeKind.Local).AddTicks(7553), new DateTime(2021, 10, 28, 16, 28, 28, 222, DateTimeKind.Local).AddTicks(7562) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 223, DateTimeKind.Local).AddTicks(8156), new DateTime(2021, 10, 28, 16, 28, 28, 223, DateTimeKind.Local).AddTicks(8199) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 223, DateTimeKind.Local).AddTicks(8423), new DateTime(2021, 10, 28, 16, 28, 28, 223, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1247), new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1269) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1482), new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1487) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1490), new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1492) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1495), new DateTime(2021, 10, 28, 16, 28, 28, 224, DateTimeKind.Local).AddTicks(1497) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b1478b3-e841-45b7-aae5-1e0c36dfb235");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b358313a-661f-4f10-bf7d-46b6db6d2f95");

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 329, DateTimeKind.Local).AddTicks(2420), new DateTime(2021, 10, 28, 16, 18, 30, 331, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 331, DateTimeKind.Local).AddTicks(7397), new DateTime(2021, 10, 28, 16, 18, 30, 331, DateTimeKind.Local).AddTicks(7405) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7652), new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7691) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7910), new DateTime(2021, 10, 28, 16, 18, 30, 332, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(884), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1108), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1112) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1115), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1118) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1120), new DateTime(2021, 10, 28, 16, 18, 30, 333, DateTimeKind.Local).AddTicks(1123) });
        }
    }
}
