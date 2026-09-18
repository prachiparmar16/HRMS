using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SoftwareType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SoftwareTbl",
                table: "SoftwareTbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HardwareTbl",
                table: "HardwareTbl");

            migrationBuilder.RenameTable(
                name: "SoftwareTbl",
                newName: "SoftwareTypetbl");

            migrationBuilder.RenameTable(
                name: "HardwareTbl",
                newName: "HardwareTypetbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoftwareTypetbl",
                table: "SoftwareTypetbl",
                column: "SoftwareTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HardwareTypetbl",
                table: "HardwareTypetbl",
                column: "HardwareTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_SoftwareTypetbl",
                table: "SoftwareTypetbl");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HardwareTypetbl",
                table: "HardwareTypetbl");

            migrationBuilder.RenameTable(
                name: "SoftwareTypetbl",
                newName: "SoftwareTbl");

            migrationBuilder.RenameTable(
                name: "HardwareTypetbl",
                newName: "HardwareTbl");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SoftwareTbl",
                table: "SoftwareTbl",
                column: "SoftwareTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HardwareTbl",
                table: "HardwareTbl",
                column: "HardwareTypeId");
        }
    }
}
