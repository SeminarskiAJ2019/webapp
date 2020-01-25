using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SeminarskiRS1.Models;
using SeminarskiRS1.Models;
using SeminarskiRS1.ViewModels.ENP;

namespace SeminarskiRS1.Controllers
{
    public class ENPController : Controller
    {
        MojDbContext db = new MojDbContext();
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Prikazi()
        {
            List<ENPPrikaziVM> enpovi = db.Enpovi.Select(e => new ENPPrikaziVM
            {
                ENPID=e.ENPID,
                Naziv=e.Naziv,
                BrTelefona=e.BrTelefona,
                Email=e.Email,
                RadnoVrijeme=e.RadnoVrijeme,
                Grad=e.Grad.Naziv
            }).ToList();
            ViewData["enp-kljuc"] = enpovi;
            return View();
        }
        public IActionResult Dodaj()
        {
            ENPUrediVM model = new ENPUrediVM();
            model.gradovi = db.Gradovi.Select(s => new SelectListItem(s.Naziv, s.GradID.ToString())).ToList();
            return View("Uredi", model);
        }
        public IActionResult Uredi(int ENPID)
        {
            ENP e = db.Enpovi.Find(ENPID);
            if (e == null)
            {
                ViewData["poruka-error"] = "ENP ne postoji.";
                return RedirectToAction(nameof(Prikazi));
            }
            ENPUrediVM model = new ENPUrediVM();
            model.gradovi = db.Gradovi.Select(s => new SelectListItem(s.Naziv, s.GradID.ToString())).ToList();
            model.GradID = e.GradID;
            model.Naziv = e.Naziv;
            model.BrTelefona = e.BrTelefona;
            model.Email = e.Email;
            model.RadnoVrijeme = e.RadnoVrijeme;
            return View("Uredi", model);
        }
        public IActionResult Snimi(ENPUrediVM input)
        {
            ENP e;
            if (input.ENPID == 0)
            {
                e = new ENP();
                db.Add(e);
                ViewData["poruka-success"] = "Uspjesno ste dodali ENP.";
            }
            else
            {
                e = db.Enpovi.Find(input.ENPID);
            }
            e.ENPID = input.ENPID;
            e.Naziv = input.Naziv;
            e.BrTelefona = input.BrTelefona;
            e.Email = input.Email;
            e.RadnoVrijeme = input.RadnoVrijeme;
            e.GradID = input.GradID;
            db.SaveChanges();
            if (input.ENPID == 0)
                ViewData["poruka-success"] = "Uspjesno ste dodali ENP.";
            else
                ViewData["poruka-success"] = "Uspjesno ste izmijenili podatke o ENP-u.";


            return RedirectToAction(nameof(Prikazi));
        }
        public IActionResult Obrisi(int ENPID)
        {
            ENP e = db.Enpovi.Find(ENPID);
            if (e == null)
            {
                ViewData["poruka-error"] = "ENP ne postoji.";
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
                    ViewData["error-poruka"] = "ENP je vezan za nešto u bazi. Nemoguće ga je izbrisati.";
                }
                ViewData["poruka-success"] = "Uspjesno ste izbrisali ENP.";
            }
            return RedirectToAction(nameof(Prikazi));
        }
    }
}