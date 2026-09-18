using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AssetType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AssetBrandtbl",
                columns: table => new
                {
                    AssetBrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetBrandtbl", x => x.AssetBrandId);
                });

            migrationBuilder.CreateTable(
                name: "AssetCategorytbl",
                columns: table => new
                {
                    AssetCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetCategorytbl", x => x.AssetCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "AssetStatustbl",
                columns: table => new
                {
                    AssetStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetStatustbl", x => x.AssetStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AssetTypetbl",
                columns: table => new
                {
                    AssetTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AssetTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AssetTypetbl", x => x.AssetTypeId);
                });

            migrationBuilder.CreateTable(
                name: "HardwareTbl",
                columns: table => new
                {
                    HardwareTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HardwareTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HardwareTbl", x => x.HardwareTypeId);
                });

            migrationBuilder.CreateTable(
                name: "SoftwareTbl",
                columns: table => new
                {
                    SoftwareTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SoftwareTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoftwareTbl", x => x.SoftwareTypeId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssetBrandtbl");

            migrationBuilder.DropTable(
                name: "AssetCategorytbl");

            migrationBuilder.DropTable(
                name: "AssetStatustbl");

            migrationBuilder.DropTable(
                name: "AssetTypetbl");

            migrationBuilder.DropTable(
                name: "HardwareTbl");

            migrationBuilder.DropTable(
                name: "SoftwareTbl");
        }
    }
}
