using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.Obavijesti;

namespace SeminarskiRS1.Controllers
{
    public class ObavijestiController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<ObavijestiPrikaziVM> obavijesti = db.Obavijesti.Select(o => new ObavijestiPrikaziVM
            {
                ObavijestID = o.ObavijestID,
                Datum=o.Datum,
                Sadrzaj=o.Sadrzaj,
                Uposlenik=o.Uposlenik.Ime
            }).ToList();
            ViewData["obavijesti-kljuc"] = obavijesti;
            return View();
        }
        public IActionResult Dodaj()
        {
            ObavijestiUrediVM model = new ObavijestiUrediVM();
            model.uposlenici = db.Uposlenici.Select(s => new SelectListItem(s.Ime, s.UposlenikID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Uredi(int ObavijestID)
        {
            Obavijesti o = db.Obavijesti.Find(ObavijestID);
            if (o == null)
            {
                ViewData["poruka_error"] = "Ne postoji ta obavijest.";
                return RedirectToAction(nameof(Prikazi));
            }
            ObavijestiUrediVM model = new ObavijestiUrediVM();
            model.uposlenici = db.Uposlenici.Select(s => new SelectListItem(s.Ime, s.UposlenikID.ToString())).ToList();
            model.Datum = o.Datum;
            model.Sadrzaj = o.Sadrzaj;
            model.UposlenikID = o.UposlenikID;
            return View("Uredi", model);
        }
        public IActionResult Snimi(ObavijestiUrediVM input)
        {
            Obavijesti o;
            if (input.ObavijestID == 0)
            {
                o = new Obavijesti();
                db.Add(o);
                ViewData["poruka_success"] = "Uspjesno ste dodali obavijest.";
            }
            else
            {
                o = db.Obavijesti.Find(input.ObavijestID);
            }
            o.ObavijestID = input.ObavijestID;
            o.Datum = input.Datum;
            o.Sadrzaj = input.Sadrzaj;
            o.UposlenikID = input.UposlenikID;
            db.SaveChanges();
            if (input.ObavijestID == 0)
                ViewData["poruka_success"] = "Uspjesno ste dodali obavijest.";
            else
                ViewData["poruka_success"] = "Uspjesno ste izmijenili podatke obavijesti.";
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Obrisi(int ObavijestID)
        {
            Obavijesti o = db.Obavijesti.Find(ObavijestID);
            if (o == null)
            {
                ViewData["poruka_error"] = "Ne postoji ta obavijest.";
            }
            else
            {
                db.Remove(o);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    ViewData["poruka_error"] = "Ne moze se izbrisati.";
                }
                ViewData["poruka_success"] = "Uspjesno ste obrisali obavijest.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
    }
}