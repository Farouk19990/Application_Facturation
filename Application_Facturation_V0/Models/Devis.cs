using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_Facturation_V0.Models
{
    public class Devis
    {
        [Key]
        public int devis_id { get; set; }
        public DateTime date_devis { get; set; }
        public double total_ht_avant_remis { get; set; }
        public double total_remise { get; set; }
        public double total_ht { get; set; }
        public double total_tva { get; set; }
        public double total_ttc { get; set; }
        public Client Devis_client { get; set; }

        
        public Produit Devis_produit { get; set; }

        public static List<Client> lClient;
        public static List<Produit> lProduit;
        public static List<LigneProduit> lLigne_Produit;

        [ForeignKey("id_client")]
        public int id_client { get; set; }
    }
}
