using Application_Facturation_V0.Data;
using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Models;
using Application_Facturation_V0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Application_Facturation_V0.Controllers
{

    public class DevisController : Controller
    {
        private readonly IDevisService _d_service;
        private readonly IProduitService _p_service;
        private readonly IClientService _c_service;
        private readonly ILigneProduitService _lp_service;

        private readonly ApplicationDbContext _context;
        public DevisController(ApplicationDbContext context, ILigneProduitService lp_service, IClientService c_service, IProduitService p_service, IDevisService d_service)
        {
            _context = context;
            _d_service = d_service;
            _p_service = p_service;
            _c_service = c_service;
            _lp_service = lp_service;
        }
        // GET: DevisController
        [HttpGet]
        public ActionResult Index()
        {

            var listP = _p_service.GetAll();
            Devis.lProduit = (List<Produit>)listP;

            var listC = _c_service.GetAll();
            Devis.lClient = (List<Client>)listC;
            
            ViewData["activeD"] = "Devis";
            var data = _d_service.GetAll();
           foreach (var i in data)
            {
                i.Devis_client = _c_service.GetById(i.id_client);
            }
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
        public ActionResult Create([Bind("id_client", "date_devis", "total_ht", "total_remise", "total_ht_avant_remis", "total_tva", "total_ttc")] Devis d)
        {
            //AddLP(d.Devis_produit);
            Devis devis = new Devis();

            if (ModelState.IsValid)
            {
                try
                {
                    devis.id_client = d.id_client;
                    devis.total_ht = d.total_ht;
                    devis.total_remise = d.total_remise;
                    devis.total_ht_avant_remis = d.total_ht_avant_remis;
                    devis.date_devis = d.date_devis;
                    devis.total_tva = d.total_tva;
                    devis.total_ttc = d.total_ttc;
                    _d_service.Add(devis);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
            
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


        // POST: DevisController
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddLP(IFormCollection form)
        {
            String qte = form["qte"];
            System.Diagnostics.Debug.WriteLine("data  " + qte);
            ViewData["qte"] = qte;
            return check();
        }
        public ActionResult check()
        {
            return View();
        }

        [HttpPost]
        public JsonResult ReceiveData([FromBody] List<Dictionary<string, string>> ligneLP)
        {
          
            var firstRow = ligneLP[0]; 
            ligneLP.RemoveAt(0);
            double TTC;
            double TVA;
            double HT;
            double Remise;
            double HTA;

            if (double.TryParse(firstRow["totalHT"], NumberStyles.Float, CultureInfo.InvariantCulture, out HT)) { }
            if (double.TryParse(firstRow["totalTTC"], NumberStyles.Float, CultureInfo.InvariantCulture, out TTC)) { }
            if (double.TryParse(firstRow["totalRemise"], NumberStyles.Float, CultureInfo.InvariantCulture, out Remise)) { }
            if (double.TryParse(firstRow["totalTVA"], NumberStyles.Float, CultureInfo.InvariantCulture, out TVA)) { }
            if (double.TryParse(firstRow["totalHTA"], NumberStyles.Float, CultureInfo.InvariantCulture, out HTA)) { }


            Devis devis = new Devis
            {
                date_devis = DateTime.Now,
                id_client = int.Parse(firstRow["client_id"]),
                total_ht = HT,
                total_remise = Remise,
                total_ht_avant_remis = HTA,
                total_ttc = TTC,
                total_tva = TVA,
            };

            _d_service.Add(devis);

            // Process the remaining rows
            foreach (var row in ligneLP)
            {
                var data = _d_service.GetAll();
                Devis devisL = data.Last();

                LigneProduit ligneProduit = new LigneProduit
                {
                    qte = int.Parse(row["qte"]),
                    remise = double.Parse(row["remise"]),
                    produit_id = int.Parse(row["ProdID"]),
                    prix_unitaire_ht = double.Parse(row["prixUnitaire"]),
                    tva = int.Parse(row["TVA"]),
                    devis_id = devisL.devis_id
                };
                _lp_service.Add(ligneProduit);
            }
            return Json(new { redirectToUrl = @Url.Action("Index", "Devis") });
        }
    }
}

