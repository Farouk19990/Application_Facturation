﻿// <auto-generated />
using System;
using Application_Facturation_V0.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Application_Facturation_V0.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230811153001_devis_Table")]
    partial class devis_Table
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Application_Facturation_V0.Models.Client", b =>
                {
                    b.Property<int>("id_client")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address_client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email_client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identifiant_unique")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matricule_fiscale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom_client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("prenom_client")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("telephone_client")
                        .HasColumnType("int");

                    b.HasKey("id_client");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.Devis", b =>
                {
                    b.Property<int>("devis_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("Devis_clientid_client")
                        .HasColumnType("int");

                    b.Property<int?>("Devis_produitproduit_id")
                        .HasColumnType("int");

                    b.Property<DateTime>("date_devis")
                        .HasColumnType("datetime2");

                    b.Property<int>("id_client")
                        .HasColumnType("int");

                    b.Property<double>("total_ht")
                        .HasColumnType("float");

                    b.Property<double>("total_ht_avant_remis")
                        .HasColumnType("float");

                    b.Property<double>("total_remise")
                        .HasColumnType("float");

                    b.Property<double>("total_ttc")
                        .HasColumnType("float");

                    b.Property<double>("total_tva")
                        .HasColumnType("float");

                    b.HasKey("devis_id");

                    b.HasIndex("Devis_clientid_client");

                    b.HasIndex("Devis_produitproduit_id");

                    b.ToTable("Devis");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.Fournisseur", b =>
                {
                    b.Property<int>("fournisseur_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("code_postal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("identifiant_unique")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("matricule_fiscale")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nom")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ville")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("fournisseur_id");

                    b.ToTable("Fournisseurs");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.LigneProduit", b =>
                {
                    b.Property<int>("ligne_produit_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("devis_id")
                        .HasColumnType("int");

                    b.Property<double>("prix_unitaire_ht")
                        .HasColumnType("float");

                    b.Property<int>("produit_id")
                        .HasColumnType("int");

                    b.Property<int?>("produit_id1")
                        .HasColumnType("int");

                    b.Property<int>("qte")
                        .HasColumnType("int");

                    b.Property<double>("remise")
                        .HasColumnType("float");

                    b.Property<int>("tva")
                        .HasColumnType("int");

                    b.Property<string>("unite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ligne_produit_id");

                    b.HasIndex("produit_id1");

                    b.ToTable("LigneProduits");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.Produit", b =>
                {
                    b.Property<int>("produit_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("designation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("fournisseurPfournisseur_id")
                        .HasColumnType("int");

                    b.Property<int>("fournisseur_id")
                        .HasColumnType("int");

                    b.Property<double>("prix_ht")
                        .HasColumnType("float");

                    b.Property<double>("prix_unitaire_ht")
                        .HasColumnType("float");

                    b.Property<int>("tva")
                        .HasColumnType("int");

                    b.Property<string>("unite")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("produit_id");

                    b.HasIndex("fournisseurPfournisseur_id");

                    b.ToTable("Produit");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.Devis", b =>
                {
                    b.HasOne("Application_Facturation_V0.Models.Client", "Devis_client")
                        .WithMany()
                        .HasForeignKey("Devis_clientid_client");

                    b.HasOne("Application_Facturation_V0.Models.Produit", "Devis_produit")
                        .WithMany()
                        .HasForeignKey("Devis_produitproduit_id");

                    b.Navigation("Devis_client");

                    b.Navigation("Devis_produit");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.LigneProduit", b =>
                {
                    b.HasOne("Application_Facturation_V0.Models.Produit", null)
                        .WithMany("ligneProduits")
                        .HasForeignKey("produit_id1");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.Produit", b =>
                {
                    b.HasOne("Application_Facturation_V0.Models.Fournisseur", "fournisseurP")
                        .WithMany()
                        .HasForeignKey("fournisseurPfournisseur_id");

                    b.Navigation("fournisseurP");
                });

            modelBuilder.Entity("Application_Facturation_V0.Models.Produit", b =>
                {
                    b.Navigation("ligneProduits");
                });
#pragma warning restore 612, 618
        }
    }
}