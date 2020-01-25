using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.Uposlenici;

namespace SeminarskiRS1.Controllers
{
    public class UposleniciController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<UposleniciPrikaziVM> uposlenici = db.Uposlenici.Select(
                u => new UposleniciPrikaziVM
                {
                    UposlenikID = u.UposlenikID,
                    Ime = u.Ime,
                    Prezime = u.Prezime,
                    BrTelefona = u.BrTelefona,
                    Email = u.Email,
                    Spol = u.Spol,
                    UposlenikTip = u.UposlenkTip.Naziv,
                    Grad = u.Grad.Naziv

                }
                    ).ToList();
            ViewData["uposlenici-kljuc"] = uposlenici;
            return View();
        }
        public IActionResult Uredi(int UposlenikID)
        {
            Uposlenik u = db.Uposlenici.Find(UposlenikID);
            if (u == null)
            {
                TempData["poruka-error"] = "Uposlenik ne postoji!";
                return RedirectToAction(nameof(Prikazi));
            }
            UposleniciUrediVM model = new UposleniciUrediVM();
            model.tipovi = db.UposlenikTipovi.Select(t => new SelectListItem(t.Naziv, t.UposlenikTipId.ToString())).ToList();
            model.UposlenikTipID = u.UposlenikTipID;
            model.gradovi = db.Gradovi.Select(g => new SelectListItem(g.Naziv, g.GradID.ToString())).ToList();
            model.GradID = u.GradID;
            model.Ime = u.Ime;
            model.Prezime = u.Prezime;
            model.BrTelefona = u.BrTelefona;
            model.Email = u.Email;
            model.Spol = u.Spol;
            return View("Uredi", model);
        }
        public IActionResult Dodaj()
        {
            UposleniciUrediVM model = new UposleniciUrediVM();
            model.tipovi = db.UposlenikTipovi.Select(t => new SelectListItem(t.Naziv, t.UposlenikTipId.ToString())).ToList();
            model.gradovi = db.Gradovi.Select(g => new SelectListItem(g.Naziv, g.GradID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Obrisi(int UposlenikID)
        {
            Uposlenik u = db.Uposlenici.Find(UposlenikID);
            if (u == null)
            {
                TempData["poruka-error"] = "Uposlenik ne postoji!";
            }
            else
            {
                db.Remove(u);
                try
                {
                    db.SaveChanges();
                }
                catch
                {
                    ViewData["error_poruka"] = "Uposlenik je vezan za nesto u bazi. Ne može se izbrisati.";
                }
                ViewData["poruka-success"] = "Uspjesno ste izbrisali uposlenika";
            }
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Snimi(UposleniciUrediVM input)
        {
            Uposlenik u;
            if (input.UposlenikID == 0)
            {
                u = new Uposlenik();
                db.Add(u);
                ViewData["poruka-success"] = "Uspjesno ste dodali uposlenika";
            }
            else
            {
                u = db.Uposlenici.Find(input.UposlenikID);
            }
            u.UposlenikID = input.UposlenikID;
            u.Ime = input.Ime;
            u.Prezime = input.Prezime;
            u.BrTelefona = input.BrTelefona;
            u.Email = input.Email;
            u.Spol = input.Spol;
            u.UposlenikTipID = input.UposlenikTipID;
            u.GradID = input.GradID;
            db.SaveChanges();
            if (input.UposlenikID == 0)
                ViewData["poruka-success"] = "Uspjesno ste dodali uposlenika.";
            else
                ViewData["poruka-success"] = "Uspjesno ste izmijenili podatke o uposleniku.";
            return RedirectToAction(nameof(Prikazi));
        }
    }
}