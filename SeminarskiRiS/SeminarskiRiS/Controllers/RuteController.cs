using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.Rute;

namespace SeminarskiRS1.Controllers
{
    public class RuteController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<RutePrikaziVM> rute = db.Rute.Select(s => new RutePrikaziVM
            {
                RutaID=s.RutaID,
                Naziv=s.Naziv,
                Pocetna=s.Pocetna,
                Zavrsna=s.Zavrsna,
                Daljina=s.Daljina,
                CijenaPutarine=s.CijenaPutarine,
                Korisnik=s.Korisnik.Ime + " " + s.Korisnik.Prezime
            }).ToList();
            ViewData["rute-kljuc"] = rute;
            return View();
        }
        public IActionResult Dodaj()
        {
            RuteUrediVM model = new RuteUrediVM();
            model.korisnici = db.Korisnici.Select(s => new SelectListItem(s.Ime + " " + s.Prezime, s.KorisnikID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Uredi(int RutaID)
        {
            Ruta r = db.Rute.Find(RutaID);
            if (r == null)
            {
                ViewData["poruka-error"] = "Ruta ne postoji u bazi.";
                return RedirectToAction(nameof(Prikazi));
            }
            RuteUrediVM model = new RuteUrediVM();
            model.korisnici = db.Korisnici.Select(s => new SelectListItem(s.Ime + " " + s.Prezime, s.KorisnikID.ToString())).ToList();
            model.KorisnikID = r.KorisnikID;
            model.Naziv = r.Naziv;
            model.Pocetna = r.Pocetna;
            model.Zavrsna = r.Zavrsna;
            model.Daljina = r.Daljina;
            model.CijenaPutarine = r.CijenaPutarine;
            return View("Uredi", model);
        }
        public IActionResult Obrisi(int RutaID)
        {
            Ruta r = db.Rute.Find(RutaID);
            if (r == null)
            {
                ViewData["poruka-error"] = "Ruta ne postoji u bazi.";
            }
            else
            {
                db.Remove(r);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    ViewData["error-poruka"] = "Ruta je vezana za nešto u bazi. Nemoguće ju je izbrisati.";
                }
                ViewData["poruka-success"] = "Uspjesno ste obrisali rutu.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Snimi(RuteUrediVM input)
        {
            Ruta r;
            if (input.RutaID == 0)
            {
                r = new Ruta();
                db.Add(r);
                ViewData["poruka-success"] = "Uspješno ste dodali novu rutu.";
            }
            else
            {
                r = db.Rute.Find(input.RutaID);
            }
            r.RutaID = input.RutaID;
            r.Naziv = input.Naziv;
            r.Pocetna = input.Pocetna;
            r.Zavrsna = input.Zavrsna;
            r.Daljina = input.Daljina;
            r.CijenaPutarine = input.CijenaPutarine;
            r.KorisnikID = input.KorisnikID;
            db.SaveChanges();
            if (input.RutaID == 0)
                ViewData["poruka-success"] = "Uspjesno ste dodali novu rutu.";
            else
                ViewData["poruka-success"] = "Uspješno ste izmijenili podatke o ruti.";


            return RedirectToAction(nameof(Prikazi));
        }
    }
}