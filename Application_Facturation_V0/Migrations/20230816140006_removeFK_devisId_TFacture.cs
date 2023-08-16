using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class removeFK_devisId_TFacture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "devis_id",
                table: "LigneFactures",
                newName: "facture_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "facture_id",
                table: "LigneFactures",
                newName: "devis_id");
        }
    }
}
