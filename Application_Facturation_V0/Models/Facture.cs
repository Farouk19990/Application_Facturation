using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace Application_Facturation_V0.Models
{
    public class Facture
    {
        [Key]
        public int facture_id { get; set; }
        public DateTime date_facture { get; set; }
        public double total_ht_avant_remis { get; set; }
        public double total_remise { get; set; }
        public double total_ht { get; set; }
        public double total_tva { get; set; }
        public double total_ttc { get; set; }
        public double frais { get; set; }
        public double timbre_fiscale { get; set; }

        public Client facture_client { get; set; }


        public Produit facture_produit { get; set; }

        public static List<Client> lClient;
        public static List<Produit> lProduit;
        public static List<LigneFacture> lLigne_Facture;

        [ForeignKey("id_client")]
        public int id_client { get; set; }
    }
}
