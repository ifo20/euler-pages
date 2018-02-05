using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace EulerPages.Migrations
{
    public partial class TestSolution : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Solutions",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Score",
                table: "Solutions",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Solutions");

            migrationBuilder.DropColumn(
                name: "Score",
                table: "Solutions");
        }
    }
}
