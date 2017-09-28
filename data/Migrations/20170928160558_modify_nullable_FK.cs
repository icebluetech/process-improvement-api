using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class modify_nullable_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "UserRoleId",
                table: "InnovationUsers",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_InnovationUsers_UserRoleId",
                table: "InnovationUsers",
                column: "UserRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_InnovationUsers_UserRoles_UserRoleId",
                table: "InnovationUsers",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InnovationUsers_UserRoles_UserRoleId",
                table: "InnovationUsers");

            migrationBuilder.DropIndex(
                name: "IX_InnovationUsers_UserRoleId",
                table: "InnovationUsers");

            migrationBuilder.DropColumn(
                name: "UserRoleId",
                table: "InnovationUsers");

            migrationBuilder.AddColumn<int>(
                name: "InnovationTypeId",
                table: "InnovationUsers",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }
    }
}
