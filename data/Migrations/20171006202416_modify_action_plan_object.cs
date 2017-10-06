using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace data.Migrations
{
    public partial class modify_action_plan_object : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "ActionPlans",
                newName: "Description");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "ActionPlans",
                newName: "Name");
        }
    }
}
