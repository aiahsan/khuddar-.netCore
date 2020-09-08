using Microsoft.EntityFrameworkCore.Migrations;

namespace KhuddarVSDatabase.Migrations
{
    public partial class fixboolArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "articleType",
                table: "KhuddarArticles",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "articleType",
                table: "KhuddarArticles",
                type: "bit",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
