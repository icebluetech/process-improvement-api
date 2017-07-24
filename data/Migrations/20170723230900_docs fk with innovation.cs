using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class docsfkwithinnovation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InnovationId",
                table: "Docs",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Docs_InnovationId",
                table: "Docs",
                column: "InnovationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Docs_Innovations_InnovationId",
                table: "Docs",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Docs_Innovations_InnovationId",
                table: "Docs");

            migrationBuilder.DropIndex(
                name: "IX_Docs_InnovationId",
                table: "Docs");

            migrationBuilder.DropColumn(
                name: "InnovationId",
                table: "Docs");
        }
    }
}
