using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Application_Facturation_V0.Models
{
    public class BonLivraison
    {
        [Key]
        public int bonLivraison_id { get; set; }
        public DateTime date_bL { get; set; }
        public double total_ht_avant_remis { get; set; }
        public double total_remise { get; set; }
        public double total_ht { get; set; }
        public double total_tva { get; set; }
        public double total_ttc { get; set; }
        public Client bL_client { get; set; }
        public Produit bL_produit { get; set; }

        public static List<Client> lClient;
        public static List<Produit> lProduit;
        public static List<LigneBL> lLigne_BL;

        [ForeignKey("id_client")]
        public int id_client { get; set; }
    }
}
