using Application_Facturation_V0.Data;
using Application_Facturation_V0.Models;
using Application_Facturation_V0.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application_Facturation_V0.Controllers
{
    public class ClientController : Controller
    {

        private readonly IClientService _c_service;
        private readonly ApplicationDbContext _context;
        public ClientController(ApplicationDbContext context, IClientService c_service)
        {    
            _context = context;
            _c_service = c_service;
        }
 
        // GET: ClientController
        public ActionResult Index()
        {
            ViewData["activeClient"] = "Client";
            var data = _c_service.GetAll();
            return View(data);
        }

        // GET: ClientController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClientController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClientController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind("nom_client","prenom_client","address_client","email_client","telephone_client", "matricule_fiscale", "identifiant_unique")] Client c)
        {
            Client client = new Client();
            if (ModelState.IsValid)
            {
                try
                {
                    client.nom_client = c.nom_client;
                    client.prenom_client = c.prenom_client;
                    client.address_client = c.address_client;
                    client.email_client = c.email_client;
                    client.telephone_client = c.telephone_client;
                    client.matricule_fiscale = c.matricule_fiscale;
                    client.identifiant_unique = c.identifiant_unique;
                    _c_service.Add(client);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();

        }
        //get
        public ActionResult EditPartial(int id)
        {
            Console.WriteLine("yooo " + id);
            Client c = _c_service.GetById(id);
            return PartialView("EditPartial",c);
        }
        //POST
        [HttpPost]
        public ActionResult EditPartial(int id, IFormCollection collection)
        {
            id = ViewBag.ClientId;
            Client c = _c_service.GetById(id);
            return PartialView("EditPartial",c);
        }
        // GET: ClientController/Edit/5
        public ActionResult Edit(int id)
        {

            Client C = _c_service.GetById(id);
            return View(C);
        }

        // POST: ClientController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [Bind("nom_client", "prenom_client", "address_client", "email_client", "telephone_client", "matricule_fiscale", "identifiant_unique")] Client c)
        {
            Client client = _c_service.GetById(id);
            if (ModelState.IsValid)
            {
                try
                {
                    client.nom_client = c.nom_client;
                    client.prenom_client = c.prenom_client;
                    client.address_client = c.address_client;
                    client.email_client = c.email_client;
                    client.telephone_client = c.telephone_client;
                    client.matricule_fiscale = c.matricule_fiscale;
                    client.identifiant_unique = c.identifiant_unique;
                    _c_service.Update(client);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View();
                }
            }
            return View();
            
        }

        // GET: ClientController/Delete/5
        public ActionResult Delete(int id)
        {
            Client client = _c_service.GetById(id);
            _c_service.Delete(client);
            return RedirectToAction(nameof(Index));
        }

        // POST: ClientController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                Client client = _c_service.GetById(id);
                _c_service.Delete(client);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
