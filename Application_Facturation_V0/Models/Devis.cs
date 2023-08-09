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
        public int ligne_produit_id { get; set; }
        [ForeignKey("ligne_produit_id")]

        public Client Devis_client { get; set; }
        public int id_client { get; set; }
        [ForeignKey("id_client")]
        public Produit Devis_produit { get; set; }

        public static List<Client> lClient;
        public static List<Produit> lProduit;



    }
}
