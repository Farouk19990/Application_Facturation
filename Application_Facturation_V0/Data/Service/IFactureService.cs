using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface IFactureService
    {
        IEnumerable<Facture> GetAll();
        Facture GetById(int id);
        void Add(Facture F);
        void Update(Facture F);
        void Delete(Facture F);
    }
}
