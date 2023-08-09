using Application_Facturation_V0.Data;
using Application_Facturation_V0.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Service
{
    public class ClientService:IClientService
    {
        private readonly ApplicationDbContext _context;
        public ClientService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Client C)
        {
            _context.Clients.Add(C);
            _context.SaveChanges();
        }

        public void Delete(Client C)
        {
            _context.Clients.Remove(C);
            _context.SaveChanges();
        }

        public IEnumerable<Client> GetAll()
        {
            var data = _context.Clients.ToList();
            return data;
        }

        public Client GetById(int id)
        {
            Client C = _context.Clients.Find(id);
            return C;
        }

        public void Update(Client C)
        {
            _context.Clients.Update(C);
            _context.SaveChanges();
        }
    }
}
