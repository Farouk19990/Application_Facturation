using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Application_Facturation_V0.Models
{
    public class LigneFacture
    {
        [Key]
        public int ligne_facture_id { get; set; }
        public int qte { get; set; }
        public double remise { get; set; }
        public double prix_unitaire_ht { get; set; }
        public double tva { get; set; }
        [ForeignKey("produit_id")]
        public int produit_id { get; set; }

        [ForeignKey("facture_id")]
        public int facture_id { get; set; }
        
        public virtual Produit produit { get; set; }

    }
}
