using Application_Facturation_V0.Models;
using System.Collections.Generic;

namespace Application_Facturation_V0.Service
{
    public interface IClientService
    {
        IEnumerable<Client> GetAll();
        Client GetById(int id);
        void Add(Client C);
        void Update(Client C);
        void Delete(Client C);
    }
}
