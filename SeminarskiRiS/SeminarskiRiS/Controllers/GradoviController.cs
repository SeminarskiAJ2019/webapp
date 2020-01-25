using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels;
using SeminarskiRS1.ViewModels.Gradovi;

namespace SeminarskiRS1.Controllers
{
    public class GradoviController : Controller
    {
        private MojDbContext db = new MojDbContext();

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<GradPrikaziVM> gradovi = db.Gradovi.Select(
                g => new GradPrikaziVM
                {
                    GradID = g.GradID,
                    Naziv = g.Naziv,
                    Kanton = g.Kanton.NazivKantonta
                }).ToList();
            ViewData["gradovi-kljuc"] = gradovi;
            return View();
        }
        public IActionResult Obrisi(int GradID)
        {
            Grad g = db.Gradovi.Find(GradID);
            if (g == null)
            {
                return Content("Grad ne postoji");
            }
            db.Remove(g);
            try
            {
                db.SaveChanges();
            }
            catch
            {
                ViewData["error_poruka"] = "Grad je vezan uz nesto u bazi. Ne moze se obrisati.";
            }
            return RedirectToAction("Prikazi");
        }
        public IActionResult Uredi(int GradID)
        {
            Grad z = db.Gradovi.Find(GradID);
            if (z == null)
            {
                ViewData["poruka-error"] = "Grad ne postoji.";
                return RedirectToAction(nameof(Prikazi));
            }
            GradUrediVM model = new GradUrediVM();
            model.kantoni = db.Kantoni.Select(k => new SelectListItem(k.NazivKantonta, k.KantonID.ToString())).ToList();
            model.KantonID = z.KantonID;
            model.Naziv = z.Naziv;

            return View("Uredi", model);
        }
        public IActionResult Snimi(GradUrediVM input)
        {
            Grad g;
            if (input.GradID == 0)
            {
                g = new Grad();
                db.Add(g);
                ViewData["poruka-succes"] = "Uspjesno ste dodali grad";
            }
            else
            {
                g = db.Gradovi.Find(input.GradID);
            }
            g.Naziv = input.Naziv;
            g.KantonID = input.KantonID;
            db.SaveChanges();
            if (input.GradID == 0)
                ViewData["poruka-sucess"] = "Uspjesno ste dodali grad";
            else
                ViewData["poruka-sucess"] = "Uspjesno ste izmijenili podatke grada";
            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Dodaj()
        {
            GradUrediVM model = new GradUrediVM();
            model.kantoni = db.Kantoni.Select(o => new SelectListItem(o.NazivKantonta, o.KantonID.ToString())).ToList();
            return View("Uredi", model);
        }
    }
}