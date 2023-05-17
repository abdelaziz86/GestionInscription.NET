using Examen.ApplicationCore.Domain;
using Examen.ApplicationCore.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Examen.UI.Web.Controllers
{
    public class InscriptionController : Controller
    { 
        private readonly IServiceInscription serviceInscription;
        private readonly IServiceParticipant serviceParticipant;
        private readonly IServiceSeminaire serviceSeminaire;


        public InscriptionController(IServiceInscription serviceInscription, IServiceParticipant serviceParticipant , IServiceSeminaire serviceSeminaire)
        {
            this.serviceInscription = serviceInscription;
            this.serviceSeminaire = serviceSeminaire;
            this.serviceParticipant = serviceParticipant;


        }
        // GET: InscriptionController
        public ActionResult Index(string nom)
        {
            var list = serviceInscription.GetAll().ToList();
            if (nom != null)
            {
                list = list.Where(f => f.Participant.nom.Contains(nom)).ToList();
            }
            return View(list);
             
        }

        // GET: InscriptionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: InscriptionController/Create
        public ActionResult Create()
        {
            ViewBag.Seminaires = new SelectList(serviceSeminaire.GetAll(), "code", "code");
            ViewBag.Participants = new SelectList(serviceParticipant.GetAll(), "id","Information" );


            return View();
        }

        // POST: InscriptionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Inscription collection)
        {
            try
            {
                serviceInscription.Add(collection);
                serviceInscription.Commit(); 
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: InscriptionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InscriptionController/Edit/5
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

        // GET: InscriptionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: InscriptionController/Delete/5
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
