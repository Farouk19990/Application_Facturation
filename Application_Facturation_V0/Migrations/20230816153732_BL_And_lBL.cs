using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class BL_And_lBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "bonLivraisons",
                columns: table => new
                {
                    bonLivraison_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_bL = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_ht_avant_remis = table.Column<double>(type: "float", nullable: false),
                    total_remise = table.Column<double>(type: "float", nullable: false),
                    total_ht = table.Column<double>(type: "float", nullable: false),
                    total_tva = table.Column<double>(type: "float", nullable: false),
                    total_ttc = table.Column<double>(type: "float", nullable: false),
                    bL_clientid_client = table.Column<int>(type: "int", nullable: true),
                    bL_produitproduit_id = table.Column<int>(type: "int", nullable: true),
                    id_client = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bonLivraisons", x => x.bonLivraison_id);
                    table.ForeignKey(
                        name: "FK_bonLivraisons_Clients_bL_clientid_client",
                        column: x => x.bL_clientid_client,
                        principalTable: "Clients",
                        principalColumn: "id_client",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_bonLivraisons_Produit_bL_produitproduit_id",
                        column: x => x.bL_produitproduit_id,
                        principalTable: "Produit",
                        principalColumn: "produit_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LignesBL",
                columns: table => new
                {
                    ligne_bonL_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qte = table.Column<int>(type: "int", nullable: false),
                    remise = table.Column<double>(type: "float", nullable: false),
                    prix_unitaire_ht = table.Column<double>(type: "float", nullable: false),
                    tva = table.Column<int>(type: "int", nullable: false),
                    produit_id = table.Column<int>(type: "int", nullable: false),
                    bonLivraison_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LignesBL", x => x.ligne_bonL_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_bonLivraisons_bL_clientid_client",
                table: "bonLivraisons",
                column: "bL_clientid_client");

            migrationBuilder.CreateIndex(
                name: "IX_bonLivraisons_bL_produitproduit_id",
                table: "bonLivraisons",
                column: "bL_produitproduit_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "bonLivraisons");

            migrationBuilder.DropTable(
                name: "LignesBL");
        }
    }
}
