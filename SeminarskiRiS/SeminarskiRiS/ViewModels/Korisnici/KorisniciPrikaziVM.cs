using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Korisnici
{
    public class KorisniciPrikaziVM
    {
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Spol { get; set; }
        public string Grad { get; set; }
        public string Vozilo { get; set; }
    }
}
