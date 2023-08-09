using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface IFournisseurService
    {
        IEnumerable<Fournisseur> GetAll();
        Fournisseur GetById(int id);
        void Add(Fournisseur F);
        void Update(Fournisseur F);
        void Delete(Fournisseur F);
    }
}
