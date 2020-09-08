using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhuddarVSDatabase.Migrations
{
    public partial class newTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhuddarArticles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    articleType = table.Column<bool>(nullable: false),
                    title = table.Column<string>(nullable: true),
                    image = table.Column<string>(nullable: true),
                    article = table.Column<string>(nullable: true),
                    videoLink = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarArticles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarEarnToPLayVideos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    videoId = table.Column<string>(nullable: true),
                    source = table.Column<string>(nullable: true),
                    amount = table.Column<string>(nullable: true),
                    title = table.Column<string>(nullable: true),
                    thumbnail = table.Column<string>(nullable: true),
                    expiryDate = table.Column<DateTime>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarEarnToPLayVideos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarQuizCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category = table.Column<string>(nullable: false),
                    status = table.Column<bool>(nullable: false),
                    deleteStatus = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarQuizCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleType = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarServices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarShadiMubarakUnlockModes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceType = table.Column<string>(nullable: true),
                    unlockMonth = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarShadiMubarakUnlockModes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarWalletType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletWithdrawMinimumAmmount = table.Column<decimal>(type: "money", nullable: false),
                    MinimumWithDrawDate = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarWalletType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarQuizs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Amount = table.Column<decimal>(type: "money", nullable: false),
                    CorrectAnswer = table.Column<int>(nullable: false),
                    HasVideo = table.Column<bool>(nullable: false),
                    VideoLink = table.Column<string>(type: "varchar(MAX)", nullable: true),
                    Time = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Category = table.Column<int>(nullable: true),
                    status = table.Column<bool>(nullable: true),
                    deleteStatus = table.Column<bool>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarQuizs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarQuizs_KhuddarQuizCategorys_Category",
                        column: x => x.Category,
                        principalTable: "KhuddarQuizCategorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Long = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    RoleId = table.Column<int>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarUsers_KhuddarRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "KhuddarRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceId = table.Column<int>(nullable: false),
                    serviceName = table.Column<string>(nullable: true),
                    unitPrice = table.Column<decimal>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarServicesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarServicesItems_KhuddarServices_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "KhuddarServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarUserWallet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ammount = table.Column<decimal>(nullable: false),
                    lastWithdraw = table.Column<DateTime>(nullable: false),
                    walletId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarUserWallet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarUserWallet_KhuddarWalletType_walletId",
                        column: x => x.walletId,
                        principalTable: "KhuddarWalletType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarQuizAnswers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Answer = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false),
                    QuizQuestion = table.Column<int>(nullable: true),
                    ansStatus = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarQuizAnswers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarQuizAnswers_KhuddarQuizs_QuizQuestion",
                        column: x => x.QuizQuestion,
                        principalTable: "KhuddarQuizs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarCofinGrantServices",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(nullable: false),
                    date = table.Column<DateTime>(nullable: false),
                    total = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarCofinGrantServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarCofinGrantServices_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarCofinRequest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(nullable: true),
                    patientName = table.Column<string>(nullable: true),
                    date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarCofinRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarCofinRequest_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarQuizCompleteds",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(nullable: true),
                    hasCompleted = table.Column<bool>(nullable: true),
                    completionDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarQuizCompleteds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarQuizCompleteds_KhuddarUsers_userId",
                        column: x => x.userId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarUserLogRecords",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Particluer = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: true),
                    UserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarUserLogRecords", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarUserLogRecords_KhuddarUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "KhuddarUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarUserDepoists",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletId = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Particluer = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    payemtnMethode = table.Column<string>(nullable: true),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarUserDepoists", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarUserDepoists_KhuddarUserWallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "KhuddarUserWallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarUserGrants",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WalletId = table.Column<int>(nullable: true),
                    Amount = table.Column<decimal>(nullable: false),
                    Particluer = table.Column<string>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    status = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarUserGrants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarUserGrants_KhuddarUserWallet_WalletId",
                        column: x => x.WalletId,
                        principalTable: "KhuddarUserWallet",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "KhuddarCofinGrantedServicesItems",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    quanity = table.Column<int>(nullable: false),
                    serviceItemId = table.Column<int>(nullable: false),
                    serviceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhuddarCofinGrantedServicesItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_KhuddarCofinGrantedServicesItems_KhuddarCofinGrantServices_serviceId",
                        column: x => x.serviceId,
                        principalTable: "KhuddarCofinGrantServices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhuddarCofinGrantedServicesItems_KhuddarServicesItems_serviceItemId",
                        column: x => x.serviceItemId,
                        principalTable: "KhuddarServicesItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarCofinGrantedServicesItems_serviceId",
                table: "KhuddarCofinGrantedServicesItems",
                column: "serviceId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarCofinGrantedServicesItems_serviceItemId",
                table: "KhuddarCofinGrantedServicesItems",
                column: "serviceItemId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarCofinGrantServices_userId",
                table: "KhuddarCofinGrantServices",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarCofinRequest_userId",
                table: "KhuddarCofinRequest",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarQuizAnswers_QuizQuestion",
                table: "KhuddarQuizAnswers",
                column: "QuizQuestion");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarQuizCompleteds_userId",
                table: "KhuddarQuizCompleteds",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarQuizs_Category",
                table: "KhuddarQuizs",
                column: "Category");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarServicesItems_ServiceId",
                table: "KhuddarServicesItems",
                column: "ServiceId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarUserDepoists_WalletId",
                table: "KhuddarUserDepoists",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarUserGrants_WalletId",
                table: "KhuddarUserGrants",
                column: "WalletId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarUserLogRecords_UserId",
                table: "KhuddarUserLogRecords",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarUsers_RoleId",
                table: "KhuddarUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_KhuddarUserWallet_walletId",
                table: "KhuddarUserWallet",
                column: "walletId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "KhuddarArticles");

            migrationBuilder.DropTable(
                name: "KhuddarCofinGrantedServicesItems");

            migrationBuilder.DropTable(
                name: "KhuddarCofinRequest");

            migrationBuilder.DropTable(
                name: "KhuddarEarnToPLayVideos");

            migrationBuilder.DropTable(
                name: "KhuddarQuizAnswers");

            migrationBuilder.DropTable(
                name: "KhuddarQuizCompleteds");

            migrationBuilder.DropTable(
                name: "KhuddarShadiMubarakUnlockModes");

            migrationBuilder.DropTable(
                name: "KhuddarUserDepoists");

            migrationBuilder.DropTable(
                name: "KhuddarUserGrants");

            migrationBuilder.DropTable(
                name: "KhuddarUserLogRecords");

            migrationBuilder.DropTable(
                name: "KhuddarCofinGrantServices");

            migrationBuilder.DropTable(
                name: "KhuddarServicesItems");

            migrationBuilder.DropTable(
                name: "KhuddarQuizs");

            migrationBuilder.DropTable(
                name: "KhuddarUserWallet");

            migrationBuilder.DropTable(
                name: "KhuddarUsers");

            migrationBuilder.DropTable(
                name: "KhuddarServices");

            migrationBuilder.DropTable(
                name: "KhuddarQuizCategorys");

            migrationBuilder.DropTable(
                name: "KhuddarWalletType");

            migrationBuilder.DropTable(
                name: "KhuddarRoles");
        }
    }
}
