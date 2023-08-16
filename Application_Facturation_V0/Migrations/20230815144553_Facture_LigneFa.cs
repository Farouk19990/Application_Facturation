using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class Facture_LigneFa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "designation",
                table: "LigneProduits");

            migrationBuilder.DropColumn(
                name: "unite",
                table: "LigneProduits");

            migrationBuilder.CreateTable(
                name: "Facture",
                columns: table => new
                {
                    facture_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_facture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_ht_avant_remis = table.Column<double>(type: "float", nullable: false),
                    total_remise = table.Column<double>(type: "float", nullable: false),
                    total_ht = table.Column<double>(type: "float", nullable: false),
                    total_tva = table.Column<double>(type: "float", nullable: false),
                    total_ttc = table.Column<double>(type: "float", nullable: false),
                    frais = table.Column<double>(type: "float", nullable: false),
                    timbre_fiscale = table.Column<double>(type: "float", nullable: false),
                    facture_clientid_client = table.Column<int>(type: "int", nullable: true),
                    facture_produitproduit_id = table.Column<int>(type: "int", nullable: true),
                    id_client = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facture", x => x.facture_id);
                    table.ForeignKey(
                        name: "FK_Facture_Clients_facture_clientid_client",
                        column: x => x.facture_clientid_client,
                        principalTable: "Clients",
                        principalColumn: "id_client",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Facture_Produit_facture_produitproduit_id",
                        column: x => x.facture_produitproduit_id,
                        principalTable: "Produit",
                        principalColumn: "produit_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LigneFactures",
                columns: table => new
                {
                    ligne_facture_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qte = table.Column<int>(type: "int", nullable: false),
                    remise = table.Column<double>(type: "float", nullable: false),
                    prix_unitaire_ht = table.Column<double>(type: "float", nullable: false),
                    tva = table.Column<int>(type: "int", nullable: false),
                    produit_id = table.Column<int>(type: "int", nullable: false),
                    devis_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigneFactures", x => x.ligne_facture_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Facture_facture_clientid_client",
                table: "Facture",
                column: "facture_clientid_client");

            migrationBuilder.CreateIndex(
                name: "IX_Facture_facture_produitproduit_id",
                table: "Facture",
                column: "facture_produitproduit_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Facture");

            migrationBuilder.DropTable(
                name: "LigneFactures");

            migrationBuilder.AddColumn<string>(
                name: "designation",
                table: "LigneProduits",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "unite",
                table: "LigneProduits",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
