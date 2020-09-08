using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhuddarVSDatabase.Migrations
{
    public partial class servicesitems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhuddarAlNikkahServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarAlNikkahServicesItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarBaraatServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarBaraatServicesItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarFoodandFoodServicesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarFoodandFoodServicesItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarFurnitureServicesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarFurnitureServicesItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarGroomSalonServicesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarGroomSalonServicesItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarMarrigeBanquetServicesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarMarrigeBanquetServicesItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarRentAHappyCarServicesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarRentAHappyCarServicesItem", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarValimaServicesItem",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    UnitCost = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarValimaServicesItem", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhuddarAlNikkahServicesItems");

            migrationBuilder.DropTable(
                name: "KhuddarBaraatServicesItems");

            migrationBuilder.DropTable(
                name: "KhuddarFoodandFoodServicesItem");

            migrationBuilder.DropTable(
                name: "KhuddarFurnitureServicesItem");

            migrationBuilder.DropTable(
                name: "KhuddarGroomSalonServicesItem");

            migrationBuilder.DropTable(
                name: "KhuddarMarrigeBanquetServicesItem");

            migrationBuilder.DropTable(
                name: "KhuddarRentAHappyCarServicesItem");

            migrationBuilder.DropTable(
                name: "KhuddarValimaServicesItem");
        }
    }
}
