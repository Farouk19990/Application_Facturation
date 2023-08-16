using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class BonLivraisonService : IBonLivraisonService
    {
        private readonly ApplicationDbContext _context;
        public BonLivraisonService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(BonLivraison F)
        {
            _context.Add(F);
            _context.SaveChanges();
        }

        public void Delete(BonLivraison F)
        {
            _context.Remove(F);
            _context.SaveChanges();
        }

        public IEnumerable<BonLivraison> GetAll()
        {
            var data = _context.bonLivraisons.ToList();
            return data;
        }

        public BonLivraison GetById(int id)
        {
            BonLivraison bl = _context.bonLivraisons.Find(id);
            return bl;
        }

        public void Update(BonLivraison F)
        {
            _context.Update(F);
            _context.SaveChanges();
        }
    }
}
