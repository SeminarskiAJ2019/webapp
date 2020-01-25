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
    public class VozilaController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<Vozilo> vozila = db.Vozila.ToList();
            ViewData["vozila-kljuc"] = vozila;

            return View();
        }
        public IActionResult Obrisi(int VoziloID)
        {
            Vozilo v = db.Vozila.Find(VoziloID);
            if (v == null)
            {
                return Content("Vozilo ne postoji!");
            }
            db.Remove(v);
            try
            {
                db.SaveChanges();
            }
            catch
            {
                ViewData["error_poruka"] = "Vozilo se ne može izbrisati.";
            }
            return RedirectToAction("Prikazi");
        }
        public IActionResult Uredi(int VoziloID)
        {
            Vozilo v = db.Vozila.Find(VoziloID);
            if (v == null)
            {
                ViewData["error_poruka"] = "Vozilo ne postoji.";
                return RedirectToAction(nameof(Prikazi));
            }
            VoziloUrediVM model = new VoziloUrediVM();
            model.VoziloID = v.VoziloID;
            model.GodinaProizvodnje = v.GodinaProizvodnje;
            model.KS = v.KS;
            model.Marka = v.Marka;
            model.Masa = v.Masa;
            model.Model = v.Model;
            model.Potrosnja = v.Potrosnja;
            model.Registracija = v.Registracija;
            model.Tip = v.Tip;
            model.VazenjeRegistracije = v.VazenjeRegistracije;
            model.ZapreminaMotora = v.ZapreminaMotora;
            return View("Uredi", model);
        }
        public IActionResult Snimi(VoziloUrediVM input)
        {
            Vozilo v;
            if (input.VoziloID == 0)
            {
                v = new Vozilo();
                db.Add(v);
                ViewData["poruka-success"] = "Uspjesno ste dodali vozilo.";
            }
            else
            {
                v = db.Vozila.Find(input.VoziloID);
            }

            v.VoziloID = input.VoziloID;
            v.GodinaProizvodnje = input.GodinaProizvodnje;
            v.KS = input.KS;
            v.Marka = input.Marka;
            v.Masa = input.Masa;
            v.Model = input.Model;
            v.Potrosnja = input.Potrosnja;
            v.Registracija = input.Registracija;
            v.Tip = input.Tip;
            v.VazenjeRegistracije = input.VazenjeRegistracije;
            v.ZapreminaMotora = input.ZapreminaMotora;

            db.SaveChanges();
            if(input.VoziloID==0)
                ViewData["poruka-success"] = "Uspjesno ste dodali vozilo.";
            else
                ViewData["poruka-success"] = "Uspjesno ste izmijenili podatke vozila.";

            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Dodaj()
        {
            VoziloUrediVM model = new VoziloUrediVM();
            return View("Uredi", model);
        }
    }
}