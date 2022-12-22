using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace esplanadeeventbooking.Server.Data.Migrations
{
    public partial class AddedDefaultDataAndUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "1fabbf7b-1fa9-4be6-868f-7bfdae798c0a", "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", "7f766357-46d0-422f-b1d3-aecab06c5fe0", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "b5486747-84d5-4393-9478-2dc3e1e879d0", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN", "AQAAAAEAACcQAAAAECeWdUFBKCVjRxtW65rZp8wp8fi3V05hKc2uYrKM17IqTRuqfgLmbbbXQYqaW9RKvw==", null, false, "5ff69d59-5373-4cc4-b3c7-326d9fc35e56", false, "Admin" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 23, 6, 19, 25, 674, DateTimeKind.Local).AddTicks(105), new DateTime(2022, 12, 23, 6, 19, 25, 674, DateTimeKind.Local).AddTicks(8010), "Black", "System" },
                    { 2, "System", new DateTime(2022, 12, 23, 6, 19, 25, 674, DateTimeKind.Local).AddTicks(8650), new DateTime(2022, 12, 23, 6, 19, 25, 674, DateTimeKind.Local).AddTicks(8653), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 23, 6, 19, 25, 675, DateTimeKind.Local).AddTicks(9021), new DateTime(2022, 12, 23, 6, 19, 25, 675, DateTimeKind.Local).AddTicks(9029), "BMW", "System" },
                    { 2, "System", new DateTime(2022, 12, 23, 6, 19, 25, 675, DateTimeKind.Local).AddTicks(9032), new DateTime(2022, 12, 23, 6, 19, 25, 675, DateTimeKind.Local).AddTicks(9033), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1623), new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1628), "3 Series", "System" },
                    { 2, "System", new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1630), new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1631), "X5", "System" },
                    { 3, "System", new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1633), new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1634), "Prius", "System" },
                    { 4, "System", new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1635), new DateTime(2022, 12, 23, 6, 19, 25, 676, DateTimeKind.Local).AddTicks(1636), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
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

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
