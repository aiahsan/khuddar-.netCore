using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhuddarVSDatabase.Migrations
{
    public partial class khuddarRequests : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhuddarAlNikkah",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    BrideName = table.Column<string>(nullable: true),
                    GroomName = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarAlNikkah", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarAlNikkah_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarBarat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    GroomName = table.Column<string>(nullable: true),
                    Baratdate = table.Column<DateTime>(nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarBarat", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarBarat_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarFoodandFood",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    GroomName = table.Column<string>(nullable: true),
                    KitchenName = table.Column<string>(nullable: true),
                    KitchenLocation = table.Column<string>(nullable: true),
                    KitchenLat = table.Column<string>(nullable: true),
                    KitchenLong = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    servicesDetails = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarFoodandFood", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarFoodandFood_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarFurniture",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    BrideName = table.Column<string>(nullable: true),
                    BanquetName = table.Column<string>(nullable: true),
                    BanquetLocation = table.Column<string>(nullable: true),
                    BanquetLat = table.Column<string>(nullable: true),
                    BanquetLong = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    servicesDetails = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarFurniture", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarFurniture_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarGroomSalon",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    GroomName = table.Column<string>(nullable: true),
                    SaloonName = table.Column<string>(nullable: true),
                    SaloonLocation = table.Column<string>(nullable: true),
                    SaloonLat = table.Column<string>(nullable: true),
                    SaloonLong = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    servicesDetails = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarGroomSalon", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarGroomSalon_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarMarrigeBanquet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    GroomName = table.Column<string>(nullable: true),
                    BanquetName = table.Column<string>(nullable: true),
                    BanquetLocation = table.Column<string>(nullable: true),
                    BanquetLat = table.Column<string>(nullable: true),
                    BanquetLong = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    servicesDetails = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarMarrigeBanquet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarMarrigeBanquet_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarRentAHappyCar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    BrideName = table.Column<string>(nullable: true),
                    GroomName = table.Column<string>(nullable: true),
                    RentACarName = table.Column<string>(nullable: true),
                    RentACarLocation = table.Column<string>(nullable: true),
                    RentACarLat = table.Column<string>(nullable: true),
                    RentACarLong = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    servicesDetails = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarRentAHappyCar", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarRentAHappyCar_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarValima",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    BrideName = table.Column<string>(nullable: true),
                    GroomName = table.Column<string>(nullable: true),
                    userId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarValima", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarValima_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarAlNikkah_userId",
                table: "KhuddarAlNikkah",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarBarat_userId",
                table: "KhuddarBarat",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarFoodandFood_userId",
                table: "KhuddarFoodandFood",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarFurniture_userId",
                table: "KhuddarFurniture",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarGroomSalon_userId",
                table: "KhuddarGroomSalon",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarMarrigeBanquet_userId",
                table: "KhuddarMarrigeBanquet",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarRentAHappyCar_userId",
                table: "KhuddarRentAHappyCar",
                column: "userId",
                unique: true,
                filter: "[userId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarValima_userId",
                table: "KhuddarValima",
                column: "userId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhuddarAlNikkah");

            migrationBuilder.DropTable(
                name: "KhuddarBarat");

            migrationBuilder.DropTable(
                name: "KhuddarFoodandFood");

            migrationBuilder.DropTable(
                name: "KhuddarFurniture");

            migrationBuilder.DropTable(
                name: "KhuddarGroomSalon");

            migrationBuilder.DropTable(
                name: "KhuddarMarrigeBanquet");

            migrationBuilder.DropTable(
                name: "KhuddarRentAHappyCar");

            migrationBuilder.DropTable(
                name: "KhuddarValima");
        }
    }
}
