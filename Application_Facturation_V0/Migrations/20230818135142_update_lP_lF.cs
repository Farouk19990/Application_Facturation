using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class update_lP_lF : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "produit_id1",
                table: "LigneFactures",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LigneFactures_produit_id1",
                table: "LigneFactures",
                column: "produit_id1");

            migrationBuilder.AddForeignKey(
                name: "FK_LigneFactures_Produit_produit_id1",
                table: "LigneFactures",
                column: "produit_id1",
                principalTable: "Produit",
                principalColumn: "produit_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LigneFactures_Produit_produit_id1",
                table: "LigneFactures");

            migrationBuilder.DropIndex(
                name: "IX_LigneFactures_produit_id1",
                table: "LigneFactures");

            migrationBuilder.DropColumn(
                name: "produit_id1",
                table: "LigneFactures");
        }
    }
}
