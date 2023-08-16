using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface ILigneFactureService
    {
        IEnumerable<LigneFacture> GetAll();
        LigneFacture GetById(int id);
        void Add(LigneFacture LF);
        void Update(LigneFacture LF);
        void Delete(LigneFacture LF);
    }
}
