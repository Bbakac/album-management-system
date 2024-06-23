using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjeKlasoru.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tbl_Album",
                columns: table => new
                {
                    Album_Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Album_No = table.Column<int>(type: "INTEGER", nullable: false),
                    Album_Tur = table.Column<string>(type: "TEXT", nullable: true),
                    Sanatci_bilgi = table.Column<string>(type: "TEXT", nullable: true),
                    Album_Adi = table.Column<string>(type: "TEXT", nullable: true),
                    Album_Fiyat = table.Column<decimal>(type: "TEXT", nullable: false),
                    yerli = table.Column<bool>(type: "INTEGER", nullable: false),
                    MenajerBilgisi = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tbl_Album", x => x.Album_Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tbl_Album");
        }
    }
}
