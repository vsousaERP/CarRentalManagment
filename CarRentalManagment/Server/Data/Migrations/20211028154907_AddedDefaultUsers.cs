using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CarRentalManagment.Server.Data.Migrations
{
    public partial class AddedDefaultUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b1478b3-e841-45b7-aae5-1e0c36dfb235",
                column: "ConcurrencyStamp",
                value: "8f63d5e2-1dfe-4bf4-bd00-dcc8f536a9dc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b358313a-661f-4f10-bf7d-46b6db6d2f95",
                column: "ConcurrencyStamp",
                value: "7d46cd96-4526-4f72-b589-85f0faea8e56");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fdb521f3-540e-4c7c-801e-09a989bd4bb1", 0, "67922f44-5134-47a7-88d6-b6f36bbd663e", "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAEKUPL7JH5WJfll+OCGUT3XLkdELiw6Ly/bimSGC57kGrHTpwsBZghcDITGQkLQNjGQ==", null, false, "e25dc7d8-a507-4256-84d3-d88b0674c1be", false, "admin@localhost.com" },
                    { "22780b4a-6510-411f-a27b-51ba342df45e", 0, "181b4a5e-4e3b-4227-ad14-970a41604561", "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", "USER@LOCALHOST.COM", "AQAAAAEAACcQAAAAEAeOgXhxKSqxWcw1O7pCJIEpkLyiW5NqyOiUqcf64dJL2hWTTEY+MP+LXLuc85S0nQ==", null, false, "04b21d04-4a80-451f-b2ba-d0750ffd85e7", false, "user@localhost.com" }
                });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 301, DateTimeKind.Local).AddTicks(2592), new DateTime(2021, 10, 28, 16, 49, 7, 303, DateTimeKind.Local).AddTicks(5488) });

            migrationBuilder.UpdateData(
                table: "Colors",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 303, DateTimeKind.Local).AddTicks(6051), new DateTime(2021, 10, 28, 16, 49, 7, 303, DateTimeKind.Local).AddTicks(6061) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(6039), new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(6270), new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(6276) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(8868), new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(9087), new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(9096), new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(9098) });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(9101), new DateTime(2021, 10, 28, 16, 49, 7, 304, DateTimeKind.Local).AddTicks(9103) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b358313a-661f-4f10-bf7d-46b6db6d2f95", "fdb521f3-540e-4c7c-801e-09a989bd4bb1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3b1478b3-e841-45b7-aae5-1e0c36dfb235", "22780b4a-6510-411f-a27b-51ba342df45e" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3b1478b3-e841-45b7-aae5-1e0c36dfb235", "22780b4a-6510-411f-a27b-51ba342df45e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b358313a-661f-4f10-bf7d-46b6db6d2f95", "fdb521f3-540e-4c7c-801e-09a989bd4bb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22780b4a-6510-411f-a27b-51ba342df45e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fdb521f3-540e-4c7c-801e-09a989bd4bb1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3b1478b3-e841-45b7-aae5-1e0c36dfb235",
                column: "ConcurrencyStamp",
                value: "3672074e-3c0c-46b3-939d-ad9682c68327");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b358313a-661f-4f10-bf7d-46b6db6d2f95",
                column: "ConcurrencyStamp",
                value: "d9459af1-ad8e-4604-9c38-ee59f01b7642");

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
    }
}
