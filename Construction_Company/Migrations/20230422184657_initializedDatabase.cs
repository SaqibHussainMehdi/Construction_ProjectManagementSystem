using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Construction_Company.Migrations
{
    public partial class initializedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customerLogins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customerLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "phases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhaseDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RatePerUnit = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "userTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TargetDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    customerLoginId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProjectAssignments_customerLogins_customerLoginId",
                        column: x => x.customerLoginId,
                        principalTable: "customerLogins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "inquireys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Area = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    RatePerSqFt = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    HomeDrawing = table.Column<bool>(type: "bit", nullable: false),
                    HomeDrawingPerSqFt = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    GreyStructure = table.Column<bool>(type: "bit", nullable: false),
                    GreyStructurePerSqFt = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    Finishing = table.Column<bool>(type: "bit", nullable: false),
                    FinishingPerSqF = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    phaseId = table.Column<int>(type: "int", nullable: false),
                    customerLoginId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inquireys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_inquireys_customerLogins_customerLoginId",
                        column: x => x.customerLoginId,
                        principalTable: "customerLogins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_inquireys_phases_phaseId",
                        column: x => x.phaseId,
                        principalTable: "phases",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    userTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_users_userTypes_userTypeId",
                        column: x => x.userTypeId,
                        principalTable: "userTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PayDesc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Paid = table.Column<int>(type: "int", nullable: false),
                    projectAssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_payments_ProjectAssignments_projectAssignmentId",
                        column: x => x.projectAssignmentId,
                        principalTable: "ProjectAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "projectStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompPercent = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    projectAssignmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projectStatuses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_projectStatuses_ProjectAssignments_projectAssignmentId",
                        column: x => x.projectAssignmentId,
                        principalTable: "ProjectAssignments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "receipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceiptDescr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    RecoverAmount = table.Column<int>(type: "int", nullable: false),
                    customerLoginId = table.Column<int>(type: "int", nullable: false),
                    ProjectAssignmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_receipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_receipts_customerLogins_customerLoginId",
                        column: x => x.customerLoginId,
                        principalTable: "customerLogins",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_receipts_ProjectAssignments_ProjectAssignmentId",
                        column: x => x.ProjectAssignmentId,
                        principalTable: "ProjectAssignments",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_inquireys_customerLoginId",
                table: "inquireys",
                column: "customerLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_inquireys_phaseId",
                table: "inquireys",
                column: "phaseId");

            migrationBuilder.CreateIndex(
                name: "IX_payments_projectAssignmentId",
                table: "payments",
                column: "projectAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_ProjectAssignments_customerLoginId",
                table: "ProjectAssignments",
                column: "customerLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_projectStatuses_projectAssignmentId",
                table: "projectStatuses",
                column: "projectAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_receipts_customerLoginId",
                table: "receipts",
                column: "customerLoginId");

            migrationBuilder.CreateIndex(
                name: "IX_receipts_ProjectAssignmentId",
                table: "receipts",
                column: "ProjectAssignmentId");

            migrationBuilder.CreateIndex(
                name: "IX_users_userTypeId",
                table: "users",
                column: "userTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "inquireys");

            migrationBuilder.DropTable(
                name: "payments");

            migrationBuilder.DropTable(
                name: "projectStatuses");

            migrationBuilder.DropTable(
                name: "receipts");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "phases");

            migrationBuilder.DropTable(
                name: "ProjectAssignments");

            migrationBuilder.DropTable(
                name: "userTypes");

            migrationBuilder.DropTable(
                name: "customerLogins");
        }
    }
}
