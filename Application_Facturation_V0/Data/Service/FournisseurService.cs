using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class FournisseurService:IFournisseurService
    {
        private readonly ApplicationDbContext _context;
        public FournisseurService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Fournisseur F)
        {
            _context.Fournisseurs.Add(F);
            _context.SaveChanges();
        }

        public void Delete(Fournisseur F)
        {
            _context.Fournisseurs.Remove(F);
            _context.SaveChanges();
        }

        public IEnumerable<Fournisseur> GetAll()
        {
            var data = _context.Fournisseurs.ToList();
            return data;
        }

        public Fournisseur GetById(int id)
        {
            Fournisseur F = _context.Fournisseurs.Find(id);
            return F;
        }

        public void Update(Fournisseur F)
        {
            _context.Fournisseurs.Update(F);
            _context.SaveChanges();
        }
    }
}
