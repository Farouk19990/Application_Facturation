using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface ILigneProduitService
    {
        IEnumerable<LigneProduit> GetAll();
        LigneProduit GetById(int id);
        void Add(LigneProduit LP);
        void Update(LigneProduit LP);
        void Delete(LigneProduit LP);
    }
}
