using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application_Facturation_V0.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application_Facturation_V0.Controllers
{
    public class ProduitController : Controller
    {

        private readonly IProduitService _p_service;
        private readonly IFournisseurService _f_service;

        private readonly ApplicationDbContext _context;
        public ProduitController(ApplicationDbContext context, IProduitService p_service, IFournisseurService f_service)
        {
            _context = context;
            _p_service = p_service;
            _f_service = f_service;

        }

        public ActionResult Create_PopUP()
        {
            var data = _f_service.GetAll();
            ViewData["ListF"] = data;

            return PartialView("Create_PopUP");
        }
        // GET: ProduitController
        public ActionResult Index()
        {
            var listF = _f_service.GetAll();
            Produit.lf = (List<Fournisseur>) listF;
          
            ViewData["activeP"] = "Produit";
            var data = _p_service.GetAll();
            foreach (Produit p in data)
            {
                p.fournisseurP = _f_service.GetById(p.fournisseur_id);
            }
            return View(data);
        }

        // GET: ProduitController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ProduitController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProduitController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("designation", "unite", "prix_unitaire_ht", "prix_ht", "tva", "fournisseur_id")] Produit p)
        {
            Produit produit = new Produit();
            if (ModelState.IsValid)
            {
                try
                {
                    produit.designation = p.designation;
                    produit.unite = p.unite;
                    produit.prix_unitaire_ht = p.prix_unitaire_ht;
                    produit.prix_ht = p.prix_ht;
                    produit.tva = p.tva;
                    
                    produit.fournisseur_id = p.fournisseur_id;                    
                    _p_service.Add(produit);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
        }

        // GET: ProduitController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProduitController/Edit/5
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

        // GET: ProduitController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProduitController/Delete/5
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
    }
}
