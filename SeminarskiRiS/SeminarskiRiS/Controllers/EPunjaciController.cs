using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.EPunjaci;

namespace SeminarskiRS1.Controllers
{
    public class EPunjaciController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<EPunjacPrikaziVM> punjaci = db.Epunjaci.Select(
                e => new EPunjacPrikaziVM
                {
                    EPunjacID = e.EPunjaciID,
                    LokacijaMap = e.LokacijaMap,
                    LokacijaNaziv = e.LokacijaNaziv,
                    Opis = e.Opis,
                    Grad = e.Grad.Naziv
                }).ToList();
            ViewData["punjaci-kljuc"] = punjaci;
            return View();
        }
        public IActionResult Dodaj()
        {
            EPunjacUrediVM model = new EPunjacUrediVM();
            model.gradovi = db.Gradovi.Select(e => new SelectListItem(e.Naziv, e.GradID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Uredi(int EPunjacID)
        {
            EPunjaci e = db.Epunjaci.Find(EPunjacID);
            if (e == null)
            {
                ViewData["poruka_error"] = "Punjac ne postoji.";
                return RedirectToAction(nameof(Prikazi));
            }
            EPunjacUrediVM model = new EPunjacUrediVM();
            model.GradID = e.GradID;
            model.gradovi = db.Gradovi.Select(g => new SelectListItem(g.Naziv, g.GradID.ToString())).ToList();
            model.LokacijaMap = e.LokacijaMap;
            model.LokacijaNaziv = e.LokacijaNaziv;
            model.Opis = e.Opis;
            return View("Uredi", model);
        }
        public IActionResult Snimi(EPunjacUrediVM input)
        {
            EPunjaci e;
            if (input.EPunjacID == 0)
            {
                e = new EPunjaci();
                db.Add(e);
                ViewData["poruka_success"] = "Uspjesno ste dodali punjac.";
            }
            else
            {
                e = db.Epunjaci.Find(input.EPunjacID);
            }
            e.EPunjaciID = input.EPunjacID;
            e.LokacijaMap = input.LokacijaMap;
            e.LokacijaNaziv = input.LokacijaNaziv;
            e.Opis = input.Opis;
            e.GradID = input.GradID;
            db.SaveChanges();
            if (input.EPunjacID == 0)
                ViewData["poruka_success"] = "Uspjesno ste dodali punjac.";
            else
                ViewData["poruka_success"] = "Uspjesno ste izmijenili podatke o punjacu.";

            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Obrisi(int EPunjacID)
        {
            EPunjaci e = db.Epunjaci.Find(EPunjacID);
            if (e == null)
            {
                ViewData["poruka_error"] = "Punjac ne postoji.";
            }
            else
            {
                db.Remove(e);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    ViewData["poruka_error"] = "Nemoguce izbrisati punjac. Vezan je za nesto u bazi.";
                }
                ViewData["poruka_success"] = "Uspjesno ste izbrisali punjac.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
    }
}