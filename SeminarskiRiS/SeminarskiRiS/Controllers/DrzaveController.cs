using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels;

namespace SeminarskiRS1.Controllers
{
    public class DrzaveController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Prikazi()
        {
            List<Drzava> drzave = db.Drzave.ToList();
            ViewData["drzave-kljuc"] = drzave;
            return View();
        }
        public IActionResult Obrisi(int DrzavaID)
        {
            Drzava d = db.Drzave.Find(DrzavaID);
            if (d == null)
            {
                return Content("Drzava ne postoji!");
            }
            db.Remove(d);
            try
            {
                db.SaveChanges();
            }
            catch
            {
                ViewData["error_poruka"] = "Drzavu je nemoguće obrisati.";
            }
            return RedirectToAction("Prikazi");
        }
        public IActionResult Uredi (int DrzavaID)
        {
            Drzava d = db.Drzave.Find(DrzavaID);
            if (d == null)
            {
                ViewData["poruka-error"] = "Drzava ne postoji.";
                return RedirectToAction(nameof(Prikazi));
            }
            DrzavaUrediVM model = new DrzavaUrediVM();
            model.DrzavaID = d.DrzavaID;
            model.Naziv = d.Naziv;
            return View("Uredi", model);
        }
        public IActionResult Snimi(DrzavaUrediVM input)
        {
            Drzava d;
            if (input.DrzavaID == 0)
            {
                d = new Drzava();
                db.Add(d);
                ViewData["poruka-success"] = "Uspjesno ste dodali drzavu.";
            }
            else
            {
                d = db.Drzave.Find(input.DrzavaID);
            }
            d.DrzavaID = input.DrzavaID;
            d.Naziv = input.Naziv;
            db.SaveChanges();
            if (input.DrzavaID == 0)
                ViewData["poruka-success"] = "Uspjesno ste dodali drzavu.";
            else
                ViewData["poruka-success"] = "Uspjesno ste izmijenili podatke o drzavi.";

            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Dodaj(string naziv)
        {
            List<string> drzave = db.Drzave.Select(s => s.Naziv).ToList();
            bool postoji = false;
            foreach(var x in drzave)
            {
                if (naziv == x)
                {
                    postoji = true;
                    break;
                }
            }
            if (!postoji)
            {
                Drzava temp = new Drzava()
                {
                    Naziv = naziv
                };
                db.Add(temp);
                db.SaveChanges();
            }
            return Redirect("/Drzave/Prikazi");
        }
        public IActionResult DodajForm()
        {
            return View("Unos");
        }
    }
    
}