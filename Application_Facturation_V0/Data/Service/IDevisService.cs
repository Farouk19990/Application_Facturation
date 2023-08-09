using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface IDevisService
    {
        IEnumerable<Devis> GetAll();
        Devis GetById(int id);
        void Add(Devis D);
        void Update(Devis D);
        void Delete(Devis D);
    }
}
