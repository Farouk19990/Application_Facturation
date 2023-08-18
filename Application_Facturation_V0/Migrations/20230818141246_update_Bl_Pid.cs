using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class update_Bl_Pid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "produitBLproduit_id",
                table: "LignesBL",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_LignesBL_produitBLproduit_id",
                table: "LignesBL",
                column: "produitBLproduit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_LignesBL_Produit_produitBLproduit_id",
                table: "LignesBL",
                column: "produitBLproduit_id",
                principalTable: "Produit",
                principalColumn: "produit_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LignesBL_Produit_produitBLproduit_id",
                table: "LignesBL");

            migrationBuilder.DropIndex(
                name: "IX_LignesBL_produitBLproduit_id",
                table: "LignesBL");

            migrationBuilder.DropColumn(
                name: "produitBLproduit_id",
                table: "LignesBL");
        }
    }
}
