using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class ligneProduit_Update_ID_devis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "client_id",
                table: "LigneProduits",
                newName: "devis_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "devis_id",
                table: "LigneProduits",
                newName: "client_id");
        }
    }
}
