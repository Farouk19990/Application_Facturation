using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class DevisService : IDevisService
    {
        private readonly ApplicationDbContext _context;
        public DevisService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Devis D)
        {
            _context.Devis.Add(D);
            _context.SaveChanges();
        }

        public void Delete(Devis D)
        {
            _context.Devis.Remove(D);
            _context.SaveChanges();
        }

        public IEnumerable<Devis> GetAll()
        {
            var data = _context.Devis.ToList();
            return data;
        }

        public Devis GetById(int id)
        {
            Devis D = _context.Devis.Find(id);
            return D;
        }

        public void Update(Devis D)
        {
            _context.Devis.Update(D);
            _context.SaveChanges();
        }
    }
}
