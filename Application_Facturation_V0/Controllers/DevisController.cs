using Application_Facturation_V0.Data;
using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Models;
using Application_Facturation_V0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Application_Facturation_V0.Controllers
{

    public class DevisController : Controller
    {
        private readonly IDevisService _d_service;
        private readonly IProduitService _p_service;
        private readonly IClientService _c_service;
        private readonly ApplicationDbContext _context;
        public DevisController(ApplicationDbContext context, IClientService c_service, IProduitService p_service, IDevisService d_service)
        {
            _context = context;
            _d_service = d_service;
            _p_service = p_service;
            _c_service = c_service;
        }
        // GET: DevisController
        public ActionResult Index()
        {

            var listP = _p_service.GetAll();
            Devis.lProduit = (List<Produit>)listP;

            var listC = _c_service.GetAll();
            Devis.lClient = (List<Client>)listC;
            
            ViewData["activeD"] = "Devis";
            var data = _d_service.GetAll();
            /*foreach (var i in data)
            {
                i.c
            }*/
            return View(data);
        }

        // GET: DevisController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DevisController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DevisController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: DevisController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DevisController/Edit/5
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

        // GET: DevisController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DevisController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
        // POST: DevisController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Get([Bind("Devis_produit.produit_id")] Devis d)
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
    }
}
