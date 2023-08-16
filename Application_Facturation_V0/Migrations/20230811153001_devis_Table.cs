using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class devis_Table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Devis_produitproduit_id",
                table: "Devis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devis_Devis_produitproduit_id",
                table: "Devis",
                column: "Devis_produitproduit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Produit_Devis_produitproduit_id",
                table: "Devis",
                column: "Devis_produitproduit_id",
                principalTable: "Produit",
                principalColumn: "produit_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Produit_Devis_produitproduit_id",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_Devis_produitproduit_id",
                table: "Devis");

            migrationBuilder.DropColumn(
                name: "Devis_produitproduit_id",
                table: "Devis");
        }
    }
}
