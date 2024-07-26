using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class RenameLeaveTypeColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LeaveTypeName",
                table: "LeaveTypes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "LeaveTypeId",
                table: "LeaveTypes",
                newName: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "LeaveTypes",
                newName: "LeaveTypeName");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "LeaveTypes",
                newName: "LeaveTypeId");
        }
    }
}
