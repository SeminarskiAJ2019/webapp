using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Rute
{
    public class RutePrikaziVM
    {
        public int RutaID { get; set; }
        public string Naziv { get; set; }
        public string Pocetna { get; set; }
        public string Zavrsna { get; set; }
        public string Daljina { get; set; }
        public string CijenaPutarine { get; set; }
        public string Korisnik { get; set; }
    }
}
