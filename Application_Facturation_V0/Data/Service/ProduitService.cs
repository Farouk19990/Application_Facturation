using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class ProduitService : IProduitService
    {
        private readonly ApplicationDbContext _context;
        public ProduitService(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Produit P)
        {
            _context.Produit.Add(P);
            _context.SaveChanges();
        }

        public void Delete(Produit P)
        {
            _context.Produit.Remove(P);
            _context.SaveChanges();
        }

        public IEnumerable<Produit> GetAll()
        {
            var data = _context.Produit.ToList();
            return data;
        }

        public Produit GetById(int id)
        {
            Produit P = _context.Produit.Find(id);
            return P;
        }

        public void Update(Produit P)
        {
            _context.Produit.Update(P);
            _context.SaveChanges();
        }
    }
}
