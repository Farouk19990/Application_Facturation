using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class removeFromDevisFK_LP_0 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Produit_id_client",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_id_client",
                table: "Devis");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Devis_id_client",
                table: "Devis",
                column: "id_client");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Produit_id_client",
                table: "Devis",
                column: "id_client",
                principalTable: "Produit",
                principalColumn: "produit_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
