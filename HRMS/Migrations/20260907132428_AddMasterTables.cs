using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.WebAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddMasterTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Canteentbl",
                columns: table => new
                {
                    CanteenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanteenName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Location = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Canteentbl", x => x.CanteenId);
                });

            migrationBuilder.CreateTable(
                name: "Certificationstbl",
                columns: table => new
                {
                    CertificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CertificationName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certificationstbl", x => x.CertificationId);
                });

            migrationBuilder.CreateTable(
                name: "Companiestbl",
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companiestbl", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeCategorystbl",
                columns: table => new
                {
                    EmployeeCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeCategorystbl", x => x.EmployeeCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypestbl",
                columns: table => new
                {
                    EmploymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmploymentTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypestbl", x => x.EmploymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategorystbl",
                columns: table => new
                {
                    FoodCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodCategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategorystbl", x => x.FoodCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "InterviewStatustbl",
                columns: table => new
                {
                    InterviewStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewStatusName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewStatustbl", x => x.InterviewStatusId);
                });

            migrationBuilder.CreateTable(
                name: "InterviewTypestbl",
                columns: table => new
                {
                    InterviewTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InterviewTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterviewTypestbl", x => x.InterviewTypeId);
                });

            migrationBuilder.CreateTable(
                name: "JobLevelstbl",
                columns: table => new
                {
                    JobLevelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobLevelName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLevelstbl", x => x.JobLevelId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitlestbl",
                columns: table => new
                {
                    JobTitleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTitleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitlestbl", x => x.JobTitleId);
                });

            migrationBuilder.CreateTable(
                name: "JobTypestbl",
                columns: table => new
                {
                    JobTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTypestbl", x => x.JobTypeId);
                });

            migrationBuilder.CreateTable(
                name: "LeavePoliciestbl",
                columns: table => new
                {
                    LeavePolicyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LeavePolicyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LeaveTypeId = table.Column<int>(type: "int", nullable: false),
                    TotalDays = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeavePoliciestbl", x => x.LeavePolicyId);
                    table.ForeignKey(
                        name: "FK_LeavePoliciestbl_LeaveTypetbl_LeaveTypeId",
                        column: x => x.LeaveTypeId,
                        principalTable: "LeaveTypetbl",
                        principalColumn: "LeaveTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealTypestbl",
                columns: table => new
                {
                    MealTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealTypestbl", x => x.MealTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Qualificationstbl",
                columns: table => new
                {
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QualificationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualificationstbl", x => x.QualificationId);
                });

            migrationBuilder.CreateTable(
                name: "RecruitmentSourcetbl",
                columns: table => new
                {
                    RecruitmentSourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecruitmentSourceName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecruitmentSourcetbl", x => x.RecruitmentSourceId);
                });

            migrationBuilder.CreateTable(
                name: "Shiftstbl",
                columns: table => new
                {
                    ShiftId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ShiftName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shiftstbl", x => x.ShiftId);
                });

            migrationBuilder.CreateTable(
                name: "Skillstbl",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skillstbl", x => x.SkillId);
                });

            migrationBuilder.CreateTable(
                name: "Branchestbl",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BranchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branchestbl", x => x.BranchId);
                    table.ForeignKey(
                        name: "FK_Branchestbl_Companiestbl_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companiestbl",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusinessUnitstbl",
                columns: table => new
                {
                    BusinessUnitId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusinessUnitName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusinessUnitstbl", x => x.BusinessUnitId);
                    table.ForeignKey(
                        name: "FK_BusinessUnitstbl_Companiestbl_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companiestbl",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CostCenterstbl",
                columns: table => new
                {
                    CostCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CostCenterName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenterstbl", x => x.CostCenterId);
                    table.ForeignKey(
                        name: "FK_CostCenterstbl_Companiestbl_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companiestbl",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemstbl",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FoodCategoryId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemstbl", x => x.FoodItemId);
                    table.ForeignKey(
                        name: "FK_FoodItemstbl_FoodCategorystbl_FoodCategoryId",
                        column: x => x.FoodCategoryId,
                        principalTable: "FoodCategorystbl",
                        principalColumn: "FoodCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealPlanstbl",
                columns: table => new
                {
                    MealPlanId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MealPlanName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MealTypeId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealPlanstbl", x => x.MealPlanId);
                    table.ForeignKey(
                        name: "FK_MealPlanstbl_MealTypestbl_MealTypeId",
                        column: x => x.MealTypeId,
                        principalTable: "MealTypestbl",
                        principalColumn: "MealTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Locationstbl",
                columns: table => new
                {
                    LocationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocationName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BranchId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locationstbl", x => x.LocationId);
                    table.ForeignKey(
                        name: "FK_Locationstbl_Branchestbl_BranchId",
                        column: x => x.BranchId,
                        principalTable: "Branchestbl",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branchestbl_CompanyId",
                table: "Branchestbl",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_BusinessUnitstbl_CompanyId",
                table: "BusinessUnitstbl",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenterstbl_CompanyId",
                table: "CostCenterstbl",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemstbl_FoodCategoryId",
                table: "FoodItemstbl",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LeavePoliciestbl_LeaveTypeId",
                table: "LeavePoliciestbl",
                column: "LeaveTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Locationstbl_BranchId",
                table: "Locationstbl",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_MealPlanstbl_MealTypeId",
                table: "MealPlanstbl",
                column: "MealTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusinessUnitstbl");

            migrationBuilder.DropTable(
                name: "Canteentbl");

            migrationBuilder.DropTable(
                name: "Certificationstbl");

            migrationBuilder.DropTable(
                name: "CostCenterstbl");

            migrationBuilder.DropTable(
                name: "EmployeeCategorystbl");

            migrationBuilder.DropTable(
                name: "EmploymentTypestbl");

            migrationBuilder.DropTable(
                name: "FoodItemstbl");

            migrationBuilder.DropTable(
                name: "InterviewStatustbl");

            migrationBuilder.DropTable(
                name: "InterviewTypestbl");

            migrationBuilder.DropTable(
                name: "JobLevelstbl");

            migrationBuilder.DropTable(
                name: "JobTitlestbl");

            migrationBuilder.DropTable(
                name: "JobTypestbl");

            migrationBuilder.DropTable(
                name: "LeavePoliciestbl");

            migrationBuilder.DropTable(
                name: "Locationstbl");

            migrationBuilder.DropTable(
                name: "MealPlanstbl");

            migrationBuilder.DropTable(
                name: "Qualificationstbl");

            migrationBuilder.DropTable(
                name: "RecruitmentSourcetbl");

            migrationBuilder.DropTable(
                name: "Shiftstbl");

            migrationBuilder.DropTable(
                name: "Skillstbl");

            migrationBuilder.DropTable(
                name: "FoodCategorystbl");

            migrationBuilder.DropTable(
                name: "Branchestbl");

            migrationBuilder.DropTable(
                name: "MealTypestbl");

            migrationBuilder.DropTable(
                name: "Companiestbl");
        }
    }
}
