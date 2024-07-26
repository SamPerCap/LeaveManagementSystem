using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDefaultRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5fced614-d4a4-4edc-aa59-43cf8b3c511c", null, "Employee", "EMPLOYEE" },
                    { "a65c545d-5a60-4eae-b072-655cd60b401e", null, "Admin", "ADMIN" },
                    { "da6784ee-d614-47d6-9926-7dbac73c29a4", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d", 0, "9485459b-1358-4af7-bae9-e4fdb0883e5e", "admin@localhost.com", true, false, null, "ADMIN@LOCALHOST.COM", "ADMINISTRATOR", "AQAAAAIAAYagAAAAEGWLHcyo3xBzYxVYp4rN8BDHl9/Lp9heRjsMtI60lgWUyRZisjN2kl7t6/5yK2FvdA==", null, false, "721a62f6-82d6-4228-a78f-a5372e0642f7", false, "Administrator" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a65c545d-5a60-4eae-b072-655cd60b401e", "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5fced614-d4a4-4edc-aa59-43cf8b3c511c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da6784ee-d614-47d6-9926-7dbac73c29a4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a65c545d-5a60-4eae-b072-655cd60b401e", "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a65c545d-5a60-4eae-b072-655cd60b401e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d");
        }
    }
}
