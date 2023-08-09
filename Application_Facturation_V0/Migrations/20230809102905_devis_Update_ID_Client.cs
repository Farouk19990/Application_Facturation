using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class devis_Update_ID_Client : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Produit_produit_id",
                table: "Devis");

            migrationBuilder.AddColumn<int>(
                name: "id_client",
                table: "Devis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devis_id_client",
                table: "Devis",
                column: "id_client");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Clients_produit_id",
                table: "Devis",
                column: "produit_id",
                principalTable: "Clients",
                principalColumn: "id_client",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Produit_id_client",
                table: "Devis",
                column: "id_client",
                principalTable: "Produit",
                principalColumn: "produit_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Clients_produit_id",
                table: "Devis");

            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Produit_id_client",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_id_client",
                table: "Devis");

            migrationBuilder.DropColumn(
                name: "id_client",
                table: "Devis");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Produit_produit_id",
                table: "Devis",
                column: "produit_id",
                principalTable: "Produit",
                principalColumn: "produit_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
