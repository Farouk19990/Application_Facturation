using System;
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
        public int produit_id { get; set; }
        [ForeignKey("produit_id")]
        public Produit produit { get; set; }




    }
}
