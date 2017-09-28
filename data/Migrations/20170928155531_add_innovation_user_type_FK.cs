using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class add_innovation_user_type_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "InnovationUsers");

            migrationBuilder.AddColumn<int>(
                name: "InnovationTypeId",
                table: "InnovationUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InnovationUsers_InnovationTypeId",
                table: "InnovationUsers",
                column: "InnovationTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_InnovationUsers_InnovationTypes_InnovationTypeId",
                table: "InnovationUsers",
                column: "InnovationTypeId",
                principalTable: "InnovationTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InnovationUsers_InnovationTypes_InnovationTypeId",
                table: "InnovationUsers");

            migrationBuilder.DropIndex(
                name: "IX_InnovationUsers_InnovationTypeId",
                table: "InnovationUsers");

            migrationBuilder.DropColumn(
                name: "InnovationTypeId",
                table: "InnovationUsers");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "InnovationUsers",
                nullable: true);
        }
    }
}
