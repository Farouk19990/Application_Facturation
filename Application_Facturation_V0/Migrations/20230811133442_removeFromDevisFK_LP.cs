using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class removeFromDevisFK_LP : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Clients_ligne_produit_id",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_ligne_produit_id",
                table: "Devis");

            migrationBuilder.DropColumn(
                name: "ligne_produit_id",
                table: "Devis");

            migrationBuilder.AddColumn<int>(
                name: "Devis_clientid_client",
                table: "Devis",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Devis_Devis_clientid_client",
                table: "Devis",
                column: "Devis_clientid_client");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Clients_Devis_clientid_client",
                table: "Devis",
                column: "Devis_clientid_client",
                principalTable: "Clients",
                principalColumn: "id_client",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devis_Clients_Devis_clientid_client",
                table: "Devis");

            migrationBuilder.DropIndex(
                name: "IX_Devis_Devis_clientid_client",
                table: "Devis");

            migrationBuilder.DropColumn(
                name: "Devis_clientid_client",
                table: "Devis");

            migrationBuilder.AddColumn<int>(
                name: "ligne_produit_id",
                table: "Devis",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Devis_ligne_produit_id",
                table: "Devis",
                column: "ligne_produit_id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devis_Clients_ligne_produit_id",
                table: "Devis",
                column: "ligne_produit_id",
                principalTable: "Clients",
                principalColumn: "id_client",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
