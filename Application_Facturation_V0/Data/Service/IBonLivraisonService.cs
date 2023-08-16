using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface IBonLivraisonService
    {
        IEnumerable<BonLivraison> GetAll();
        BonLivraison GetById(int id);
        void Add(BonLivraison BL);
        void Update(BonLivraison BL);
        void Delete(BonLivraison BL);
    }
}
