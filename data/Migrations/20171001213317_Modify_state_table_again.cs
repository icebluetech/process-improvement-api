using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class Modify_state_table_again : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProvidedMeasure",
                table: "States",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TimeTakenMeasure",
                table: "States",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProvidedMeasure",
                table: "States");

            migrationBuilder.DropColumn(
                name: "TimeTakenMeasure",
                table: "States");
        }
    }
}
