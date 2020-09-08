using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KhuddarVSDatabase.Migrations
{
    public partial class baseAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Date",
                table: "KhuddarUsers",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "KhuddarUserLogRecords",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "KhuddarUserGrants",
                newName: "date");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "KhuddarUserDepoists",
                newName: "date");

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "KhuddarWalletType",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarWalletType",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarWalletType",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarUserWallet",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarUserWallet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarUserWallet",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarUsers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "KhuddarUserLogRecords",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarUserLogRecords",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarUserLogRecords",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarUserGrants",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarUserDepoists",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarShadiMubarakUnlockModes",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarShadiMubarakUnlockModes",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarServicesItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarServicesItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarServices",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "KhuddarRoles",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarRoles",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarRoles",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "KhuddarQuizs",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarQuizs",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "KhuddarQuizs",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarQuizCompleteds",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarQuizCompleteds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarQuizCompleteds",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarQuizCategorys",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarQuizAnswers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarQuizAnswers",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarEarnToPLayVideos",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarEarnToPLayVideos",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarCofinRequest",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarCofinRequest",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarCofinGrantServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarCofinGrantServices",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "date",
                table: "KhuddarCofinGrantedServicesItems",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarCofinGrantedServicesItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "status",
                table: "KhuddarCofinGrantedServicesItems",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarArticles",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarWalletType");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarWalletType");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarUserWallet");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarUserWallet");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarUserWallet");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarUsers");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarUsers");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarUserLogRecords");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarUserLogRecords");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarUserGrants");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarUserDepoists");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarShadiMubarakUnlockModes");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarShadiMubarakUnlockModes");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarServicesItems");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarServicesItems");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarServices");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarServices");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarRoles");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarRoles");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarQuizCompleteds");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarQuizCompleteds");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarQuizCompleteds");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarQuizCategorys");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarQuizAnswers");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarQuizAnswers");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarEarnToPLayVideos");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarEarnToPLayVideos");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarCofinRequest");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarCofinRequest");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarCofinGrantServices");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarCofinGrantServices");

            migrationBuilder.DropColumn(
                name: "date",
                table: "KhuddarCofinGrantedServicesItems");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarCofinGrantedServicesItems");

            migrationBuilder.DropColumn(
                name: "status",
                table: "KhuddarCofinGrantedServicesItems");

            migrationBuilder.DropColumn(
                name: "deleteStatus",
                table: "KhuddarArticles");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "KhuddarUsers",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "KhuddarUserLogRecords",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "KhuddarUserGrants",
                newName: "Date");

            migrationBuilder.RenameColumn(
                name: "date",
                table: "KhuddarUserDepoists",
                newName: "Date");

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "KhuddarWalletType",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "Date",
                table: "KhuddarUserLogRecords",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "KhuddarRoles",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "status",
                table: "KhuddarQuizs",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<bool>(
                name: "deleteStatus",
                table: "KhuddarQuizs",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool));

            migrationBuilder.AlterColumn<DateTime>(
                name: "date",
                table: "KhuddarQuizs",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime));
        }
    }
}
