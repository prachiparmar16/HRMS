using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class SalaryComponent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AllowanceTypetbl",
                columns: table => new
                {
                    AllowanceTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowanceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsTaxable = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllowanceTypetbl", x => x.AllowanceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "DeductionTypetbl",
                columns: table => new
                {
                    DeductionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DeductionName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsMandatory = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DeductionTypetbl", x => x.DeductionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "PayFrequencytbl",
                columns: table => new
                {
                    PayFrequencyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FrequencyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FrequencyDays = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayFrequencytbl", x => x.PayFrequencyId);
                });

            migrationBuilder.CreateTable(
                name: "SalaryComponentstbl",
                columns: table => new
                {
                    SalaryComponentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComponentName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ComponentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    IsTaxable = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryComponentstbl", x => x.SalaryComponentId);
                });

            migrationBuilder.CreateTable(
                name: "SalaryGradestbl",
                columns: table => new
                {
                    SalaryGradeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    MinimumSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryGradestbl", x => x.SalaryGradeId);
                });

            migrationBuilder.CreateTable(
                name: "TaxSlabstbl",
                columns: table => new
                {
                    TaxSlabId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SlabName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MinimumIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumIncome = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxSlabstbl", x => x.TaxSlabId);
                });

            migrationBuilder.CreateTable(
                name: "PayrollPolicytbl",
                columns: table => new
                {
                    PayrollPolicyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    PayFrequencyId = table.Column<int>(type: "int", nullable: false),
                    IncludeTax = table.Column<bool>(type: "bit", nullable: false),
                    IncludePF = table.Column<bool>(type: "bit", nullable: false),
                    IncludeESI = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayrollPolicytbl", x => x.PayrollPolicyId);
                    table.ForeignKey(
                        name: "FK_PayrollPolicytbl_PayFrequencytbl_PayFrequencyId",
                        column: x => x.PayFrequencyId,
                        principalTable: "PayFrequencytbl",
                        principalColumn: "PayFrequencyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PayrollPolicytbl_PayFrequencyId",
                table: "PayrollPolicytbl",
                column: "PayFrequencyId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AllowanceTypetbl");

            migrationBuilder.DropTable(
                name: "DeductionTypetbl");

            migrationBuilder.DropTable(
                name: "PayrollPolicytbl");

            migrationBuilder.DropTable(
                name: "SalaryComponentstbl");

            migrationBuilder.DropTable(
                name: "SalaryGradestbl");

            migrationBuilder.DropTable(
                name: "TaxSlabstbl");

            migrationBuilder.DropTable(
                name: "PayFrequencytbl");
        }
    }
}
