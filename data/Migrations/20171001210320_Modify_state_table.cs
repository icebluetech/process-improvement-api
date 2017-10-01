using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class Modify_state_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Satisfied",
                table: "States",
                newName: "EmpSatisfied");

            migrationBuilder.AddColumn<int>(
                name: "CustSatisfied",
                table: "States",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustSatisfied",
                table: "States");

            migrationBuilder.RenameColumn(
                name: "EmpSatisfied",
                table: "States",
                newName: "Satisfied");
        }
    }
}
