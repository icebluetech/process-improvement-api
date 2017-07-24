using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class makerootcauseanalysisoptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Innovations_RootCauseAnalysies_RootCauseAnalysisId",
                table: "Innovations");

            migrationBuilder.AlterColumn<int>(
                name: "RootCauseAnalysisId",
                table: "Innovations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Innovations_RootCauseAnalysies_RootCauseAnalysisId",
                table: "Innovations",
                column: "RootCauseAnalysisId",
                principalTable: "RootCauseAnalysies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Innovations_RootCauseAnalysies_RootCauseAnalysisId",
                table: "Innovations");

            migrationBuilder.AlterColumn<int>(
                name: "RootCauseAnalysisId",
                table: "Innovations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Innovations_RootCauseAnalysies_RootCauseAnalysisId",
                table: "Innovations",
                column: "RootCauseAnalysisId",
                principalTable: "RootCauseAnalysies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
