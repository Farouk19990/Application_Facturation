using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Application_Facturation_V0.Models
{
    public class Produit
    {
        [Key]
        public int produit_id { get; set; }
        public string designation { get; set; }
        public string unite { get; set; }
        public double prix_unitaire_ht { get; set; }
        public double prix_ht { get; set; }
        public int tva { get; set; }
        [ForeignKey("fournisseur_id")]
        public int fournisseur_id { get; set; }
        public static List<Fournisseur> lf { get; set; }
        public Fournisseur fournisseurP { get; set;}
        public List<LigneProduit> ligneProduits { get; set;}
      
    }
}
