using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_Facturation_V0.Models
{
    public class LigneProduit
    {
        [Key]
        public int ligne_produit_id { get; set; }
        public int qte { get; set; }
        public double remise { get; set; }
        public double prix_unitaire_ht { get; set; }
        public int tva { get; set; }
        [ForeignKey("produit_id")]
        public int produit_id { get; set; }

        [ForeignKey("devis_id")]
        public int devis_id { get; set; }

    }
}
