using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Facturation_V0.Models
{
    public class Client
    {
        [Key]
        public int id_client { get; set; }
        public string nom_client { get; set; }
        public string prenom_client { get; set; }
        //public int cin { get; set; }

        public string matricule_fiscale { get; set; }
        public string identifiant_unique { get; set; }
        public string address_client { get; set; }
        public string email_client { get; set; }
        public int telephone_client { get; set; }
        [ForeignKey("client_id")]
        public int client_id { get; set; }

    }
}
