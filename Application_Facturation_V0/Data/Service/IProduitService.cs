using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface IProduitService
    {
        IEnumerable<Produit> GetAll();
        Produit GetById(int id);
        void Add(Produit P);
        void Update(Produit P);
        void Delete(Produit P);
    }
}
