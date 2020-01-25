using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.Servisi;

namespace SeminarskiRS1.Controllers
{
    public class ServisController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<ServisPrikaziVM> servisi = db.Servisi.Select(
                s => new ServisPrikaziVM
                {
                    ServisID = s.ServisID,
                    LokacijaMap=s.LokacijaMap,
                    Opis=s.Opis,
                    RadnoVrijeme=s.RadnoVrijeme,
                    Usluge=s.Usluge,
                    Grad=s.Grad.Naziv
                }).ToList();
            ViewData["servisi-kljuc"] = servisi;
            return View();
        }
        public IActionResult Dodaj()
        {
            ServisUrediVM model = new ServisUrediVM();
            model.gradovi = db.Gradovi.Select(s => new SelectListItem(s.Naziv, s.GradID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Uredi(int ServisID)
        {
            Servis s = db.Servisi.Find(ServisID);
            if (s == null)
            {
                ViewData["poruka_error"] = "Ne postoji ovaj servis.";
                return RedirectToAction(nameof(Prikazi));
            }
            ServisUrediVM model = new ServisUrediVM();
            model.gradovi = db.Gradovi.Select(s => new SelectListItem(s.Naziv, s.GradID.ToString())).ToList();
            model.GradID = s.GradID;
            model.LokacijaMap = s.LokacijaMap;
            model.Opis = s.Opis;
            model.RadnoVrijeme = s.RadnoVrijeme;
            model.Usluge = s.Usluge;
            return View("Uredi", model);
        }
        public IActionResult Obrisi(int ServisID)
        {
            Servis s = db.Servisi.Find(ServisID);
            if (s == null)
            {
                ViewData["poruka_error"] = "Ne postoji ovaj servis";
            }
            else
            {
                db.Remove(s);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    ViewData["error_poruka"] = "Servis je vezan za nesto u bazi, ne moze se obrisati.";
                }
                ViewData["poruka_success"] = "Uspjesno ste obrisali servis.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Snimi(ServisUrediVM input)
        {
            Servis s;
            if (input.ServisID == 0)
            {
                s = new Servis();
                db.Add(s);
                ViewData["poruka_success"] = "Uspjesno ste dodali servis";
            }
            else
            {
                s = db.Servisi.Find(input.ServisID);
            }
            s.ServisID = input.ServisID;
            s.LokacijaMap = input.LokacijaMap;
            s.Opis = input.Opis;
            s.RadnoVrijeme = input.RadnoVrijeme;
            s.Usluge = input.Usluge;
            s.GradID = input.GradID;
            db.SaveChanges();
            if (input.ServisID == 0)
                ViewData["poruka_success"] = "Uspjesno ste dodali servis.";
            else
                ViewData["poruka_success"] = "Uspjesno ste izmijenili podatke o servisu.";
            return RedirectToAction(nameof(Prikazi));
        }
    }
}