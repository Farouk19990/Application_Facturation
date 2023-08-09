using System;
using System.ComponentModel.DataAnnotations;

namespace Application_Facturation_V0.Models
{
    public class Fournisseur
    {
        [Key]
        public int fournisseur_id { get; set; }
        public string nom { get; set; }
        public string matricule_fiscale { get; set; }
        public string identifiant_unique { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string code_postal { get; set; }
        public string ville { get; set; }

    }
}
