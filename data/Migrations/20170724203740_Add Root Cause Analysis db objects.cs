using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class AddRootCauseAnalysisdbobjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RootCauseAnalysies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "RootCauseAnalysies",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_RootCauseAnalysies_UserId",
                table: "RootCauseAnalysies",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RootCauseAnalysies_Users_UserId",
                table: "RootCauseAnalysies",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RootCauseAnalysies_Users_UserId",
                table: "RootCauseAnalysies");

            migrationBuilder.DropIndex(
                name: "IX_RootCauseAnalysies_UserId",
                table: "RootCauseAnalysies");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "RootCauseAnalysies");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "RootCauseAnalysies");
        }
    }
}
