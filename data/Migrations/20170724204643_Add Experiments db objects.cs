using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class AddExperimentsdbobjects : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InnovationId",
                table: "Experiments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Experiments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Experiments_InnovationId",
                table: "Experiments",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_Experiments_UserId",
                table: "Experiments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Experiments_Innovations_InnovationId",
                table: "Experiments",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Experiments_Users_UserId",
                table: "Experiments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Experiments_Innovations_InnovationId",
                table: "Experiments");

            migrationBuilder.DropForeignKey(
                name: "FK_Experiments_Users_UserId",
                table: "Experiments");

            migrationBuilder.DropIndex(
                name: "IX_Experiments_InnovationId",
                table: "Experiments");

            migrationBuilder.DropIndex(
                name: "IX_Experiments_UserId",
                table: "Experiments");

            migrationBuilder.DropColumn(
                name: "InnovationId",
                table: "Experiments");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Experiments");
        }
    }
}
