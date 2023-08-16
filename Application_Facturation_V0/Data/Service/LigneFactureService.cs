using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class LigneFactureService : ILigneFactureService
    {
        private readonly ApplicationDbContext _context;
        public LigneFactureService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(LigneFacture LF)
        {
            _context.Add(LF);
            _context.SaveChanges();
        }

        public void Delete(LigneFacture LF)
        {
            _context.Remove(LF);
            _context.SaveChanges();
        }

        public IEnumerable<LigneFacture> GetAll()
        {
            var data = _context.LigneFactures.ToList();
            return data;
        }

        public LigneFacture GetById(int id)
        {
            LigneFacture lf = _context.LigneFactures.Find(id);
            return lf;
        }

        public void Update(LigneFacture LF)
        {
            _context.Update(LF);
            _context.SaveChanges();
        }
    }
}
