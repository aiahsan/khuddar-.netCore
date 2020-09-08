using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhuddarVSDatabase.Migrations
{
    public partial class dateCangeNikkah : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "valimaDate",
                table: "KhuddarValima",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "NikkahDate",
                table: "KhuddarAlNikkah",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "valimaDate",
                table: "KhuddarValima");

            migrationBuilder.DropColumn(
                name: "NikkahDate",
                table: "KhuddarAlNikkah");
        }
    }
}
