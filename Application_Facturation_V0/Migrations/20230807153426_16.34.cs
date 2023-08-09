using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Application_Facturation_V0.Migrations
{
    public partial class _1634 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    id_client = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom_client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prenom_client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricule_fiscale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identifiant_unique = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address_client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email_client = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone_client = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.id_client);
                });

            migrationBuilder.CreateTable(
                name: "Fournisseurs",
                columns: table => new
                {
                    fournisseur_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    matricule_fiscale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    identifiant_unique = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    telephone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    code_postal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ville = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fournisseurs", x => x.fournisseur_id);
                });

            migrationBuilder.CreateTable(
                name: "Produit",
                columns: table => new
                {
                    produit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prix_unitaire_ht = table.Column<double>(type: "float", nullable: false),
                    prix_ht = table.Column<double>(type: "float", nullable: false),
                    tva = table.Column<int>(type: "int", nullable: false),
                    fournisseur_id = table.Column<int>(type: "int", nullable: false),
                    fournisseurPfournisseur_id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produit", x => x.produit_id);
                    table.ForeignKey(
                        name: "FK_Produit_Fournisseurs_fournisseurPfournisseur_id",
                        column: x => x.fournisseurPfournisseur_id,
                        principalTable: "Fournisseurs",
                        principalColumn: "fournisseur_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Devis",
                columns: table => new
                {
                    devis_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date_devis = table.Column<DateTime>(type: "datetime2", nullable: false),
                    total_ht_avant_remis = table.Column<double>(type: "float", nullable: false),
                    total_remise = table.Column<double>(type: "float", nullable: false),
                    total_ht = table.Column<double>(type: "float", nullable: false),
                    total_tva = table.Column<double>(type: "float", nullable: false),
                    total_ttc = table.Column<double>(type: "float", nullable: false),
                    produit_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Devis", x => x.devis_id);
                    table.ForeignKey(
                        name: "FK_Devis_Produit_produit_id",
                        column: x => x.produit_id,
                        principalTable: "Produit",
                        principalColumn: "produit_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LigneProduits",
                columns: table => new
                {
                    ligne_produit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qte = table.Column<int>(type: "int", nullable: false),
                    remise = table.Column<double>(type: "float", nullable: false),
                    designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    unite = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    prix_unitaire_ht = table.Column<double>(type: "float", nullable: false),
                    tva = table.Column<int>(type: "int", nullable: false),
                    produit_id = table.Column<int>(type: "int", nullable: false),
                    client_id = table.Column<int>(type: "int", nullable: false),
                    produit_id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LigneProduits", x => x.ligne_produit_id);
                    table.ForeignKey(
                        name: "FK_LigneProduits_Produit_produit_id1",
                        column: x => x.produit_id1,
                        principalTable: "Produit",
                        principalColumn: "produit_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Devis_produit_id",
                table: "Devis",
                column: "produit_id");

            migrationBuilder.CreateIndex(
                name: "IX_LigneProduits_produit_id1",
                table: "LigneProduits",
                column: "produit_id1");

            migrationBuilder.CreateIndex(
                name: "IX_Produit_fournisseurPfournisseur_id",
                table: "Produit",
                column: "fournisseurPfournisseur_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Devis");

            migrationBuilder.DropTable(
                name: "LigneProduits");

            migrationBuilder.DropTable(
                name: "Produit");

            migrationBuilder.DropTable(
                name: "Fournisseurs");
        }
    }
}
