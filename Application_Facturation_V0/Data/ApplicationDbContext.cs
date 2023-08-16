using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Facturation_V0.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Client> Clients { get; set;}
        public DbSet<Devis> Devis { get; set; }
        public DbSet<Fournisseur> Fournisseurs { get; set; }
        public DbSet<LigneProduit> LigneProduits { get; set; }
        public DbSet<Produit> Produit { get; set; }
        public DbSet<Facture> Facture { get; set; }
        public DbSet<LigneFacture> LigneFactures { get; set; }
        public DbSet<BonLivraison> bonLivraisons { get; set; }
        public DbSet<LigneBL> LignesBL { get; set; }


    }
}
