using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class FactureService : IFactureService
    {
        private readonly ApplicationDbContext _context;
        public FactureService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Facture F)
        {
            _context.Add(F);
            _context.SaveChanges();
        }

        public void Delete(Facture F)
        {
            _context.Remove(F);
            _context.SaveChanges();
        }

        public IEnumerable<Facture> GetAll()
        {
            var data = _context.Facture.ToList();
            return data;
        }

        public Facture GetById(int id)
        {
            Facture f = _context.Facture.Find(id);
            return f;
        }

        public void Update(Facture F)
        {
            _context.Update(F);
            _context.SaveChanges();
        }
    }
}
