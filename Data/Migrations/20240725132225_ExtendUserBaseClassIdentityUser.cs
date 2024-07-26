using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class ExtendUserBaseClassIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateOnly>(
                name: "DateOfBirth",
                table: "AspNetUsers",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d",
                columns: new[] { "ConcurrencyStamp", "DateOfBirth", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ecc3d9f6-a445-492f-8ef8-3e3de20d74b2", new DateOnly(2001, 1, 1), "Default", "Admin", "AQAAAAIAAYagAAAAEB6pujfjSh2C7RXzUzI3jnuIJvOWLwndUZRpDb06LG5SaU98TIh62XBbBSW5iG62Xw==", "a3279086-640f-4e94-9354-4e6dd0ee53e8" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateOfBirth",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02ccb3b3-9a18-4ed6-9f5b-81c2782ab06d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9485459b-1358-4af7-bae9-e4fdb0883e5e", "AQAAAAIAAYagAAAAEGWLHcyo3xBzYxVYp4rN8BDHl9/Lp9heRjsMtI60lgWUyRZisjN2kl7t6/5yK2FvdA==", "721a62f6-82d6-4228-a78f-a5372e0642f7" });
        }
    }
}
