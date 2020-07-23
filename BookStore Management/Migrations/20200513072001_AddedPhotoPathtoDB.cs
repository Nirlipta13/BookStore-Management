using Microsoft.EntityFrameworkCore.Migrations;

namespace BookStore_Management.Migrations
{
    public partial class AddedPhotoPathtoDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoPath",
                table: "Books",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoPath",
                table: "Books");
        }
    }
}
