using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class LigneProduitService : ILigneProduitService
    {
        private readonly ApplicationDbContext _context;
        public LigneProduitService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(LigneProduit LP)
        {
            _context.LigneProduits.Add(LP);
            _context.SaveChanges();
        }

        public void Delete(LigneProduit LP)
        {
            _context.LigneProduits.Remove(LP);
            _context.SaveChanges();
        }

        public IEnumerable<LigneProduit> GetAll()
        {

            var data = _context.LigneProduits.ToList();
            return data;
        }

        public LigneProduit GetById(int id)
        {
            LigneProduit LP = _context.LigneProduits.Find(id);
            return LP;
        }

        public void Update(LigneProduit LP)
        {
            _context.LigneProduits.Update(LP);
            _context.SaveChanges();
        }
    }
}
