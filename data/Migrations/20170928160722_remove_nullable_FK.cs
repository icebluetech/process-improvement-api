using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class remove_nullable_FK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InnovationUsers_UserRoles_UserRoleId",
                table: "InnovationUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "InnovationUsers",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InnovationUsers_UserRoles_UserRoleId",
                table: "InnovationUsers",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InnovationUsers_UserRoles_UserRoleId",
                table: "InnovationUsers");

            migrationBuilder.AlterColumn<int>(
                name: "UserRoleId",
                table: "InnovationUsers",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_InnovationUsers_UserRoles_UserRoleId",
                table: "InnovationUsers",
                column: "UserRoleId",
                principalTable: "UserRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
