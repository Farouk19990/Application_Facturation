using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Data.Service
{
    public class LigneBL_Service : ILigneBL_Service
    {
        private readonly ApplicationDbContext _context;
        public LigneBL_Service(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(LigneBL lBL)
        {
            _context.Add(lBL);
            _context.SaveChanges();
        }

        public void Delete(LigneBL lBL)
        {
            _context.Remove(lBL);
            _context.SaveChanges();
        }

        public IEnumerable<LigneBL> GetAll()
        {
            var data = _context.LignesBL.ToList();
            return data;
        }

        public LigneBL GetById(int id)
        {
            LigneBL bl = _context.LignesBL.Find(id);
            return bl;
        }

        public void Update(LigneBL lBL)
        {
            _context.Update(lBL);
            _context.SaveChanges();
        }
    }
}
