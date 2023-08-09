using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class devis_Update_ID_Ligne_Produit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Clients_produit_id",
                table: "Devis");

            migrationBuilder.RenameColumn(
                name: "produit_id",
                table: "Devis",
                newName: "ligne_produit_id");

            migrationBuilder.RenameIndex(
                name: "IX_Devis_produit_id",
                table: "Devis",
                newName: "IX_Devis_ligne_produit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Clients_ligne_produit_id",
                table: "Devis",
                column: "ligne_produit_id",
                principalTable: "Clients",
                principalColumn: "id_client",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Clients_ligne_produit_id",
                table: "Devis");

            migrationBuilder.RenameColumn(
                name: "ligne_produit_id",
                table: "Devis",
                newName: "produit_id");

            migrationBuilder.RenameIndex(
                name: "IX_Devis_ligne_produit_id",
                table: "Devis",
                newName: "IX_Devis_produit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Clients_produit_id",
                table: "Devis",
                column: "produit_id",
                principalTable: "Clients",
                principalColumn: "id_client",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
