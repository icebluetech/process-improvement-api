using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace data.Migrations
{
    public partial class Add_results_db_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "Percentage",
                table: "Results");

            migrationBuilder.DropColumn(
                name: "TimeUnit",
                table: "Results");

            migrationBuilder.RenameColumn(
                name: "Number",
                table: "Results",
                newName: "InnovationId");

            migrationBuilder.CreateTable(
                name: "ResultEntryTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultEntryTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultEntries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CurrentState = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Goal = table.Column<int>(nullable: false),
                    Ninety = table.Column<int>(nullable: false),
                    ResultEntryTypeId = table.Column<int>(nullable: false),
                    ResultId = table.Column<int>(nullable: false),
                    Sixty = table.Column<int>(nullable: false),
                    Thirty = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResultEntries_ResultEntryTypes_ResultEntryTypeId",
                        column: x => x.ResultEntryTypeId,
                        principalTable: "ResultEntryTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ResultEntries_Results_ResultId",
                        column: x => x.ResultId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Results_InnovationId",
                table: "Results",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultEntries_ResultEntryTypeId",
                table: "ResultEntries",
                column: "ResultEntryTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ResultEntries_ResultId",
                table: "ResultEntries",
                column: "ResultId");

            migrationBuilder.AddForeignKey(
                name: "FK_Results_Innovations_InnovationId",
                table: "Results",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Results_Innovations_InnovationId",
                table: "Results");

            migrationBuilder.DropTable(
                name: "ResultEntries");

            migrationBuilder.DropTable(
                name: "ResultEntryTypes");

            migrationBuilder.DropIndex(
                name: "IX_Results_InnovationId",
                table: "Results");

            migrationBuilder.RenameColumn(
                name: "InnovationId",
                table: "Results",
                newName: "Number");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Results",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "Percentage",
                table: "Results",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TimeUnit",
                table: "Results",
                nullable: true);
        }
    }
}
