using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Noobboyz.Migrations
{
    public partial class hug : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "tb_ProductImage",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "tb_ProductImage");
        }
    }
}
