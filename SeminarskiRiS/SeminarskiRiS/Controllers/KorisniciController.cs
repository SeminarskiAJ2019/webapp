using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.Korisnici;

namespace SeminarskiRS1.Controllers
{
    public class KorisniciController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<KorisniciPrikaziVM> korisnici = db.Korisnici.Select(k => new KorisniciPrikaziVM
            {
                KorisnikID=k.KorisnikID,
                Ime=k.Ime,
                Prezime=k.Prezime,
                BrTelefona=k.BrTelefona,
                Email=k.Email,
                Adresa=k.Adresa,
                Spol=k.Spol,
                Grad=k.Grad.Naziv,
                Vozilo=k.Vozilo.Marka
            }).ToList();
            ViewData["korisnici-kljuc"] = korisnici;
            return View();
        }
        public IActionResult Dodaj()
        {
            KorisniciUrediVM model = new KorisniciUrediVM();
            model.gradovi = db.Gradovi.Select(s => new SelectListItem(s.Naziv, s.GradID.ToString())).ToList();
            model.vozila = db.Vozila.Select(v => new SelectListItem(v.Marka + " " + v.Model, v.VoziloID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Uredi(int KorisnikID)
        {
            Korisnik k = db.Korisnici.Find(KorisnikID);
            if (k == null)
            {
                ViewData["poruka-error"] = "Korisnik ne postoji u bazi.";
                return RedirectToAction(nameof(Prikazi));
            }
            KorisniciUrediVM model = new KorisniciUrediVM();
            model.gradovi = db.Gradovi.Select(s => new SelectListItem(s.Naziv, s.GradID.ToString())).ToList();
            model.GradID = k.GradID;
            model.vozila = db.Vozila.Select(v => new SelectListItem(v.Marka + " " + v.Model, v.VoziloID.ToString())).ToList();
            model.VoziloID = k.VoziloID;
            model.Ime = k.Ime;
            model.Prezime = k.Prezime;
            model.BrTelefona = k.BrTelefona;
            model.Email = k.Email;
            model.Adresa = k.Adresa;
            model.Spol = k.Spol;
            return View("Uredi", model);
        }
        public IActionResult Obrisi(int KorisnikID)
        {
            Korisnik k = db.Korisnici.Find(KorisnikID);
            if (k == null)
            {
                ViewData["poruka-error"] = "Korisnik ne postoji u bazi.";
            }
            else
            {
                db.Remove(k);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    ViewData["error-poruka"] = "Korisnik je vezan za nesto u bazi. Nemoguće ga je izbrisati.";
                }
                ViewData["poruka-success"] = "Uspjesno ste izbrisali korisnika.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Snimi(KorisniciUrediVM input)
        {
            Korisnik k;
            if (input.KorisnikID == 0)
            {
                k = new Korisnik();
                db.Add(k);
                ViewData["poruka-succes"] = "Uspjesno ste dodali novog korisnika.";
            }
            else
            {
                k = db.Korisnici.Find(input.KorisnikID);
            }
            k.KorisnikID = input.KorisnikID;
            k.Ime = input.Ime;
            k.Prezime = input.Prezime;
            k.BrTelefona = input.BrTelefona;
            k.Email = input.Email;
            k.Adresa = input.Adresa;
            k.Spol = input.Spol;
            k.GradID = input.GradID;
            k.VoziloID = input.VoziloID;
            db.SaveChanges();
            if (input.KorisnikID == 0)
                ViewData["poruka-success"] = "Uspjesno ste dodali novog korisnika.";
            else
                ViewData["poruka-success"] = "Uspjesno ste izmijenili podatke o korisniku.";


            return RedirectToAction(nameof(Prikazi));
        }
    }
}