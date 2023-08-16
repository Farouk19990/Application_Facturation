using Application_Facturation_V0.Data.Service;
using Application_Facturation_V0.Data;
using Application_Facturation_V0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Application_Facturation_V0.Models;
using System.Collections.Generic;
using System.Globalization;
using System;
using System.Linq;

namespace Application_Facturation_V0.Controllers
{
    public class BonLivraisonController : Controller
    {
        private readonly IBonLivraisonService _bl_service;
        private readonly IProduitService _p_service;
        private readonly IClientService _c_service;
        private readonly ILigneBL_Service _Lbl_service;

        private readonly ApplicationDbContext _context;
        public BonLivraisonController(ApplicationDbContext context, ILigneBL_Service Lbl_service, IClientService c_service, IProduitService p_service, IBonLivraisonService bl_service)
        {
            _context = context;
            _bl_service = bl_service;
            _p_service = p_service;
            _c_service = c_service;
            _Lbl_service = Lbl_service;
        }
        // GET: BonLivraisonController
        public ActionResult Index()
        {
            var listP = _p_service.GetAll();
            BonLivraison.lProduit = (List<Produit>)listP;

            var listC = _c_service.GetAll();
            BonLivraison.lClient = (List<Client>)listC;

            ViewData["activeBL"] = "BL";
            var data = _bl_service.GetAll();
            foreach (var i in data)
            {
                i.bL_client = _c_service.GetById(i.id_client);
            }
            return View(data);
        }

        // GET: BonLivraisonController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BonLivraisonController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BonLivraisonController/Create
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

        // GET: BonLivraisonController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BonLivraisonController/Edit/5
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

        // GET: BonLivraisonController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BonLivraisonController/Delete/5
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

            if (double.TryParse(firstRow["totalHT"], NumberStyles.Float, CultureInfo.InvariantCulture, out HT)) { }
            if (double.TryParse(firstRow["totalTTC"], NumberStyles.Float, CultureInfo.InvariantCulture, out TTC)) { }
            if (double.TryParse(firstRow["totalRemise"], NumberStyles.Float, CultureInfo.InvariantCulture, out Remise)) { }
            if (double.TryParse(firstRow["totalTVA"], NumberStyles.Float, CultureInfo.InvariantCulture, out TVA)) { }
            if (double.TryParse(firstRow["totalHTA"], NumberStyles.Float, CultureInfo.InvariantCulture, out HTA)) { }


            BonLivraison bonLivraison = new BonLivraison
            {
                date_bL = DateTime.Now,
                id_client = int.Parse(firstRow["client_id"]),
                total_ht = HT,
                total_remise = Remise,
                total_ht_avant_remis = HTA,
                total_ttc = TTC,
                total_tva = TVA,
            };

            _bl_service.Add(bonLivraison);

            // Process the remaining rows
            foreach (var row in ligneLP)
            {
                var data = _bl_service.GetAll();
                BonLivraison bL = data.Last();

                LigneBL ligneBL = new LigneBL
                {
                    qte = int.Parse(row["qte"]),
                    remise = double.Parse(row["remise"]),
                    produit_id = int.Parse(row["ProdID"]),
                    prix_unitaire_ht = double.Parse(row["prixUnitaire"]),
                    tva = int.Parse(row["TVA"]),
                    bonLivraison_id = bL.bonLivraison_id
                };
                _Lbl_service.Add(ligneBL);
            }
            return Json(new { redirectToUrl = @Url.Action("Index", "BonLivraison") });
        }
    }
}
