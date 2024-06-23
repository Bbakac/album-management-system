using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeKlasoru.Migrations
{
    public partial class RemoveMenajerBilgisiFromTblAlbum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MenajerBilgisi",
                table: "Tbl_Album");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MenajerBilgisi",
                table: "Tbl_Album",
                type: "TEXT",
                nullable: true);
        }
    }
}
