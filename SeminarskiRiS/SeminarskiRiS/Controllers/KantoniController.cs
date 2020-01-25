using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels;
using SeminarskiRS1.ViewModels.Kantoni;

namespace SeminarskiRS1.Controllers
{
    public class KantoniController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<KantonPrikaziVM> kantoni = db.Kantoni.Select(
                k => new KantonPrikaziVM
                {
                    KantonID = k.KantonID,
                    NazivKantonta = k.NazivKantonta,
                    Skracenica = k.Skracenica,
                    Drzava = k.Drzava.Naziv
                }).ToList();
            ViewData["kantoni-kljuc"] = kantoni;
            return View();
        }
        public IActionResult Dodaj()
        {
            KantonUrediVM model = new KantonUrediVM();
            model.drzave = db.Drzave.Select(s => new SelectListItem(s.Naziv, s.DrzavaID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Snimi(KantonUrediVM input)
        {
            Kanton k;
            if (input.KantonID == 0)
            {
                k = new Kanton();
                db.Add(k);
                TempData["poruka-success"] = "Uspjesno ste dodali kanton.";
            }
            else
            {
                k = db.Kantoni.Find(input.KantonID);
            }
            k.NazivKantonta = input.NazivKantonta;
            k.Skracenica = input.Skracenica;
            k.DrzavaID = input.DrzavaID;
            db.SaveChanges();
            if (input.KantonID == 0)
                TempData["poruka-success"] = "Uspjesno ste dodali kanton";
            else
                TempData["poruka-success"] = "Uspjesno ste izmijenili podatke o kantonima";
            db.Dispose();
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Uredi(int KantonID)
        {
            Kanton k = db.Kantoni.Find(KantonID);
            if (k == null)
            {
                TempData["poruka-error"] = "Kanton ne postoji.";
                return RedirectToAction(nameof(Prikazi));
            }
            KantonUrediVM model = new KantonUrediVM();
            model.drzave = db.Drzave.Select(d => new SelectListItem(d.Naziv, d.DrzavaID.ToString())).ToList();
            model.DrzavaID = k.DrzavaID;
            model.NazivKantonta = k.NazivKantonta;
            model.Skracenica = k.Skracenica;


            return View("Uredi", model);
        }
        public IActionResult Obrisi(int KantonID)
        {
            Kanton k = db.Kantoni.Find(KantonID);
            if (k == null)
            {
                TempData["poruka-error"] = "Ne postoji kanton.";
            }
            else
            {
                db.Remove(k);
                db.SaveChanges();
                TempData["poruka-success"] = "Uspjesno ste izbrisali kanton.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
    }
    
}