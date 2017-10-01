using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class Add_gap_analysis_innovation_link : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InnovationId",
                table: "GapAnalysis",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GapAnalysis_InnovationId",
                table: "GapAnalysis",
                column: "InnovationId");

            migrationBuilder.AddForeignKey(
                name: "FK_GapAnalysis_Innovations_InnovationId",
                table: "GapAnalysis",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GapAnalysis_Innovations_InnovationId",
                table: "GapAnalysis");

            migrationBuilder.DropIndex(
                name: "IX_GapAnalysis_InnovationId",
                table: "GapAnalysis");

            migrationBuilder.DropColumn(
                name: "InnovationId",
                table: "GapAnalysis");
        }
    }
}
