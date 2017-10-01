using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace data.Migrations
{
    public partial class Add_lessons_learned_db_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InnovationId",
                table: "States",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "LessonsLearned",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    InnovationId = table.Column<int>(nullable: false),
                    NotWorked = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true),
                    Worked = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LessonsLearned", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LessonsLearned_Innovations_InnovationId",
                        column: x => x.InnovationId,
                        principalTable: "Innovations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_States_InnovationId",
                table: "States",
                column: "InnovationId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonsLearned_InnovationId",
                table: "LessonsLearned",
                column: "InnovationId");

            migrationBuilder.AddForeignKey(
                name: "FK_States_Innovations_InnovationId",
                table: "States",
                column: "InnovationId",
                principalTable: "Innovations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_States_Innovations_InnovationId",
                table: "States");

            migrationBuilder.DropTable(
                name: "LessonsLearned");

            migrationBuilder.DropIndex(
                name: "IX_States_InnovationId",
                table: "States");

            migrationBuilder.DropColumn(
                name: "InnovationId",
                table: "States");
        }
    }
}
