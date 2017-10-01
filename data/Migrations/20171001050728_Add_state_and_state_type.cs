using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace data.Migrations
{
    public partial class Add_state_and_state_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StateType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Approvals = table.Column<int>(nullable: false),
                    BacklogNumber = table.Column<int>(nullable: false),
                    BacklogWork = table.Column<int>(nullable: false),
                    Correct = table.Column<int>(nullable: false),
                    Handoffs = table.Column<int>(nullable: false),
                    Provided = table.Column<int>(nullable: false),
                    Satisfied = table.Column<int>(nullable: false),
                    StateTypeId = table.Column<int>(nullable: false),
                    TimeTaken = table.Column<int>(nullable: false),
                    WidgetId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_StateType_StateTypeId",
                        column: x => x.StateTypeId,
                        principalTable: "StateType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_State_Widgets_WidgetId",
                        column: x => x.WidgetId,
                        principalTable: "Widgets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_State_StateTypeId",
                table: "State",
                column: "StateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_State_WidgetId",
                table: "State",
                column: "WidgetId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "StateType");
        }
    }
}
