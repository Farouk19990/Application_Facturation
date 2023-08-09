using Application_Facturation_V0.Data;
using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Models;
using Application_Facturation_V0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application_Facturation_V0.Controllers
{
    public class FournisseurController : Controller
    {
        private readonly IFournisseurService _f_service;
        private readonly ApplicationDbContext _context;
        public FournisseurController(ApplicationDbContext context, IFournisseurService f_service)
        {
            _context = context;
            _f_service = f_service;
        }
        // GET: FournisseurController
        public ActionResult Index()
        {
            ViewData["activeF"] = "Fournisseur";
            var data = _f_service.GetAll();
            return View(data);
        }

        // GET: FournisseurController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FournisseurController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FournisseurController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("nom", "matricule_fiscale", "identifiant_unique", "address", "telephone", "code_postal", "ville")] Fournisseur f)
        {
            Fournisseur fournisseur = new Fournisseur();
            if (ModelState.IsValid)
            {
                try
                {
                    fournisseur.nom = f.nom;
                    fournisseur.matricule_fiscale = f.matricule_fiscale;
                    fournisseur.identifiant_unique = f.identifiant_unique;
                    fournisseur.address = f.address;
                    fournisseur.code_postal = f.code_postal;
                    fournisseur.ville = f.ville;
                    fournisseur.telephone = f.telephone;
                    _f_service.Add(fournisseur);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();

        }

        // GET: FournisseurController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FournisseurController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: FournisseurController/Delete/5
        public ActionResult Delete(int id)
        {
            Fournisseur fournisseur = _f_service.GetById(id);
            _f_service.Delete(fournisseur);
            return RedirectToAction(nameof(Index));
        }

        // POST: FournisseurController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Fournisseur fournisseur = _f_service.GetById(id);
                _f_service.Delete(fournisseur);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
