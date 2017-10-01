using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace data.Migrations
{
    public partial class Add_brainstorm_db_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brainstorms_Users_UserId",
                table: "Brainstorms");

            migrationBuilder.DropIndex(
                name: "IX_Brainstorms_UserId",
                table: "Brainstorms");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Brainstorms");

            migrationBuilder.DropColumn(
                name: "Impact",
                table: "Brainstorms");

            migrationBuilder.DropColumn(
                name: "LevelOfEffort",
                table: "Brainstorms");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Brainstorms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Brainstorms");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Docs",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BrainstormFileTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrainstormFileTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrainstormFiles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrainstormFileTypeId = table.Column<int>(nullable: false),
                    BrainstormId = table.Column<int>(nullable: true),
                    DocId = table.Column<int>(nullable: false),
                    Expectation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrainstormFiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrainstormFiles_BrainstormFileTypes_BrainstormFileTypeId",
                        column: x => x.BrainstormFileTypeId,
                        principalTable: "BrainstormFileTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrainstormFiles_Brainstorms_BrainstormId",
                        column: x => x.BrainstormId,
                        principalTable: "Brainstorms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BrainstormFiles_Docs_DocId",
                        column: x => x.DocId,
                        principalTable: "Docs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrainstormFiles_BrainstormFileTypeId",
                table: "BrainstormFiles",
                column: "BrainstormFileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_BrainstormFiles_BrainstormId",
                table: "BrainstormFiles",
                column: "BrainstormId");

            migrationBuilder.CreateIndex(
                name: "IX_BrainstormFiles_DocId",
                table: "BrainstormFiles",
                column: "DocId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrainstormFiles");

            migrationBuilder.DropTable(
                name: "BrainstormFileTypes");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Docs");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Brainstorms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Impact",
                table: "Brainstorms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LevelOfEffort",
                table: "Brainstorms",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Brainstorms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Brainstorms",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Brainstorms_UserId",
                table: "Brainstorms",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Brainstorms_Users_UserId",
                table: "Brainstorms",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
