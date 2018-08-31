using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BartenderApp.Migrations
{
    public partial class InitialCreat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DrinkName",
                table: "Drinks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "orderTime",
                table: "Drinks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DrinkName",
                table: "Drinks");

            migrationBuilder.DropColumn(
                name: "orderTime",
                table: "Drinks");
        }
    }
}
