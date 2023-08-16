using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Data.Service
{
    public interface ILigneBL_Service
    {
        IEnumerable<LigneBL> GetAll();
        LigneBL GetById(int id);
        void Add(LigneBL lBL);
        void Update(LigneBL lBL);
        void Delete(LigneBL lBL);
    }
}
