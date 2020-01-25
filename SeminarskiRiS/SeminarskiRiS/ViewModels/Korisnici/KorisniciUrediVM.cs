using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Korisnici
{
    public class KorisniciUrediVM
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Spol { get; set; }
        public int GradID { get; set; }
        public List<SelectListItem> gradovi { get; set; }
        public int VoziloID { get; set; }
        public List<SelectListItem> vozila { get; set; }
    }
}
