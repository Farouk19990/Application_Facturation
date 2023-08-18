using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_Facturation_V0.Models
{
    public class LigneBL
    {
        [Key]
        public int ligne_bonL_id { get; set; }
        public int qte { get; set; }
        public double remise { get; set; }
        public double prix_unitaire_ht { get; set; }
        public double tva { get; set; }
        [ForeignKey("produit_id")]
        public int produit_id { get; set; }

        [ForeignKey("bonLivraison_id")]
        public int bonLivraison_id { get; set; }

        public Produit produitBL { get; set; }
    }
}
