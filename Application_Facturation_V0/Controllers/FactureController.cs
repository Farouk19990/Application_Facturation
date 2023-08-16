using Application_Facturation_V0.Data;
using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Models;
using Application_Facturation_V0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace Application_Facturation_V0.Controllers
{
    public class FactureController : Controller
    {

        private readonly IFactureService _f_service;
        private readonly IProduitService _p_service;
        private readonly IClientService _c_service;
        private readonly ILigneFactureService _lf_service;

        private readonly ApplicationDbContext _context;
        public FactureController(ApplicationDbContext context, ILigneFactureService lf_service, IClientService c_service, IProduitService p_service, IFactureService f_service)
        {
            _context = context;
            _f_service = f_service;
            _p_service = p_service;
            _c_service = c_service;
            _lf_service = lf_service;
        }
        // GET: FactureController
        public ActionResult Index()
        {
            var listP = _p_service.GetAll();
            Facture.lProduit = (List<Produit>)listP;

            var listC = _c_service.GetAll();
            Facture.lClient = (List<Client>)listC;

            ViewData["activeF"] = "Facture";
            var data = _f_service.GetAll();
            foreach (var i in data)
            {
                i.facture_client = _c_service.GetById(i.id_client);
            }
            return View(data);
        }

        // GET: FactureController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: FactureController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FactureController/Create
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

        // GET: FactureController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: FactureController/Edit/5
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

        // GET: FactureController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: FactureController/Delete/5
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
            double frais;
            if (double.TryParse(firstRow["totalHT"], NumberStyles.Float, CultureInfo.InvariantCulture, out HT)) { }
            if (double.TryParse(firstRow["totalTTC"], NumberStyles.Float, CultureInfo.InvariantCulture, out TTC)) { }
            if (double.TryParse(firstRow["totalRemise"], NumberStyles.Float, CultureInfo.InvariantCulture, out Remise)) { }
            if (double.TryParse(firstRow["totalTVA"], NumberStyles.Float, CultureInfo.InvariantCulture, out TVA)) { }
            if (double.TryParse(firstRow["totalHTA"], NumberStyles.Float, CultureInfo.InvariantCulture, out HTA)) { }
            if (double.TryParse(firstRow["Frais"], NumberStyles.Float, CultureInfo.InvariantCulture, out frais)) { }

            Facture facture = new Facture
            {
                date_facture = DateTime.Now,
                id_client = int.Parse(firstRow["client_id"]),
                total_ht = HT,
                total_remise = Remise,
                total_ht_avant_remis = HTA,
                total_ttc = TTC,
                total_tva = TVA,
                frais= frais,
                timbre_fiscale=1
            };

            _f_service.Add(facture);

            // Process the remaining rows
            foreach (var row in ligneLP)
            {
                var data = _f_service.GetAll();
                Facture factureL = data.Last();

                LigneFacture ligneFacture = new LigneFacture
                {
                    qte = int.Parse(row["qte"]),
                    remise = double.Parse(row["remise"]),
                    produit_id = int.Parse(row["ProdID"]),
                    prix_unitaire_ht = double.Parse(row["prixUnitaire"]),
                    tva = int.Parse(row["TVA"]),
                    facture_id = factureL.facture_id,
                };
                _lf_service.Add(ligneFacture);
            }
            return Json(new { redirectToUrl = @Url.Action("Index", "Facture") });
        }
    }
}
