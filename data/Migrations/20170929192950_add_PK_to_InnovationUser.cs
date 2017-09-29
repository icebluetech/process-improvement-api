using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace data.Migrations
{
    public partial class add_PK_to_InnovationUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InnovationCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnovationCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InnovationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnovationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Number = table.Column<int>(nullable: false),
                    Percentage = table.Column<decimal>(nullable: false),
                    TimeUnit = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StandardWorks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StandardWorks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tools",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Widgets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Widgets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UserRoleId = table.Column<int>(nullable: false),
                    avatar = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RootCauseAnalysies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Tool = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RootCauseAnalysies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RootCauseAnalysies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trainings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ApprovalNeeded = table.Column<bool>(nullable: false),
                    Completed = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trainings_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Innovations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentState = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    DepartmentId = table.Column<int>(nullable: true),
                    FutureState = table.Column<string>(nullable: true),
                    InnovationCategoryId = table.Column<int>(nullable: false),
                    InnovationTypeId = table.Column<int>(nullable: false),
                    ProcessId = table.Column<int>(nullable: true),
                    RootCauseAnalysisId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Why = table.Column<string>(nullable: true),
                    WidgetId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Innovations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Innovations_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Innovations_InnovationCategories_InnovationCategoryId",
                        column: x => x.InnovationCategoryId,
                        principalTable: "InnovationCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Innovations_InnovationTypes_InnovationTypeId",
                        column: x => x.InnovationTypeId,
                        principalTable: "InnovationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Innovations_Processes_ProcessId",
                        column: x => x.ProcessId,
                        principalTable: "Processes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Innovations_RootCauseAnalysies_RootCauseAnalysisId",
                        column: x => x.RootCauseAnalysisId,
                        principalTable: "RootCauseAnalysies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Innovations_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Brainstorms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true),
                    Impact = table.Column<string>(nullable: true),
                    InnovationId = table.Column<int>(nullable: false),
                    LevelOfEffort = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brainstorms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brainstorms_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Brainstorms_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Celebrates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InnovationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celebrates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Celebrates_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Docs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InnovationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Docs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Docs_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Experiments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompletionDate = table.Column<DateTime>(nullable: false),
                    InnovationId = table.Column<int>(nullable: false),
                    Status = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false),
                    What = table.Column<string>(nullable: true),
                    When = table.Column<string>(nullable: true),
                    Who = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Experiments_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Experiments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InnovationUsers",
                columns: table => new
                {
                    InnovationId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    UserRoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InnovationUsers", x => new { x.InnovationId, x.UserId });
                    table.ForeignKey(
                        name: "FK_InnovationUsers_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InnovationUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InnovationUsers_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InnovationId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brainstorms_InnovationId",
                table: "Brainstorms",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_Brainstorms_UserId",
                table: "Brainstorms",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Celebrates_InnovationId",
                table: "Celebrates",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_Docs_InnovationId",
                table: "Docs",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiments_InnovationId",
                table: "Experiments",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiments_UserId",
                table: "Experiments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_DepartmentId",
                table: "Innovations",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_InnovationCategoryId",
                table: "Innovations",
                column: "InnovationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_InnovationTypeId",
                table: "Innovations",
                column: "InnovationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_ProcessId",
                table: "Innovations",
                column: "ProcessId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_RootCauseAnalysisId",
                table: "Innovations",
                column: "RootCauseAnalysisId");

            migrationBuilder.CreateIndex(
                name: "IX_Innovations_WidgetId",
                table: "Innovations",
                column: "WidgetId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationUsers_UserId",
                table: "InnovationUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_InnovationUsers_UserRoleId",
                table: "InnovationUsers",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_InnovationId",
                table: "Tasks",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_RootCauseAnalysies_UserId",
                table: "RootCauseAnalysies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Trainings_UserId",
                table: "Trainings",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserRoleId",
                table: "Users",
                column: "UserRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brainstorms");

            migrationBuilder.DropTable(
                name: "Celebrates");

            migrationBuilder.DropTable(
                name: "Docs");

            migrationBuilder.DropTable(
                name: "Experiments");

            migrationBuilder.DropTable(
                name: "InnovationUsers");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropTable(
                name: "StandardWorks");

            migrationBuilder.DropTable(
                name: "Tools");

            migrationBuilder.DropTable(
                name: "Trainings");

            migrationBuilder.DropTable(
                name: "Innovations");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "InnovationCategories");

            migrationBuilder.DropTable(
                name: "InnovationTypes");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "RootCauseAnalysies");

            migrationBuilder.DropTable(
                name: "Widgets");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserRoles");
        }
    }
}
