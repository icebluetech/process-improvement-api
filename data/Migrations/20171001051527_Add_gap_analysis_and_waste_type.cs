using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace data.Migrations
{
    public partial class Add_gap_analysis_and_waste_type : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReasonForAction_Innovations_InnovationId",
                table: "ReasonForAction");

            migrationBuilder.DropForeignKey(
                name: "FK_State_StateType_StateTypeId",
                table: "State");

            migrationBuilder.DropForeignKey(
                name: "FK_State_Widgets_WidgetId",
                table: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateType",
                table: "StateType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_State",
                table: "State");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReasonForAction",
                table: "ReasonForAction");

            migrationBuilder.RenameTable(
                name: "StateType",
                newName: "StateTypes");

            migrationBuilder.RenameTable(
                name: "State",
                newName: "States");

            migrationBuilder.RenameTable(
                name: "ReasonForAction",
                newName: "ReasonForActions");

            migrationBuilder.RenameIndex(
                name: "IX_State_WidgetId",
                table: "States",
                newName: "IX_States_WidgetId");

            migrationBuilder.RenameIndex(
                name: "IX_State_StateTypeId",
                table: "States",
                newName: "IX_States_StateTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ReasonForAction_InnovationId",
                table: "ReasonForActions",
                newName: "IX_ReasonForActions_InnovationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateTypes",
                table: "StateTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_States",
                table: "States",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReasonForActions",
                table: "ReasonForActions",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "WasteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WasteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GapAnalysis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NVA = table.Column<int>(nullable: false),
                    NonValueHold = table.Column<int>(nullable: false),
                    Url = table.Column<string>(nullable: true),
                    ValueHold = table.Column<int>(nullable: false),
                    WasteTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GapAnalysis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GapAnalysis_WasteTypes_WasteTypeId",
                        column: x => x.WasteTypeId,
                        principalTable: "WasteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_GapAnalysis_WasteTypeId",
                table: "GapAnalysis",
                column: "WasteTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReasonForActions_Innovations_InnovationId",
                table: "ReasonForActions",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_StateTypes_StateTypeId",
                table: "States",
                column: "StateTypeId",
                principalTable: "StateTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_Widgets_WidgetId",
                table: "States",
                column: "WidgetId",
                principalTable: "Widgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReasonForActions_Innovations_InnovationId",
                table: "ReasonForActions");

            migrationBuilder.DropForeignKey(
                name: "FK_States_StateTypes_StateTypeId",
                table: "States");

            migrationBuilder.DropForeignKey(
                name: "FK_States_Widgets_WidgetId",
                table: "States");

            migrationBuilder.DropTable(
                name: "GapAnalysis");

            migrationBuilder.DropTable(
                name: "WasteTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StateTypes",
                table: "StateTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_States",
                table: "States");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ReasonForActions",
                table: "ReasonForActions");

            migrationBuilder.RenameTable(
                name: "StateTypes",
                newName: "StateType");

            migrationBuilder.RenameTable(
                name: "States",
                newName: "State");

            migrationBuilder.RenameTable(
                name: "ReasonForActions",
                newName: "ReasonForAction");

            migrationBuilder.RenameIndex(
                name: "IX_States_WidgetId",
                table: "State",
                newName: "IX_State_WidgetId");

            migrationBuilder.RenameIndex(
                name: "IX_States_StateTypeId",
                table: "State",
                newName: "IX_State_StateTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_ReasonForActions_InnovationId",
                table: "ReasonForAction",
                newName: "IX_ReasonForAction_InnovationId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StateType",
                table: "StateType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_State",
                table: "State",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ReasonForAction",
                table: "ReasonForAction",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ReasonForAction_Innovations_InnovationId",
                table: "ReasonForAction",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_State_StateType_StateTypeId",
                table: "State",
                column: "StateTypeId",
                principalTable: "StateType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_State_Widgets_WidgetId",
                table: "State",
                column: "WidgetId",
                principalTable: "Widgets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
