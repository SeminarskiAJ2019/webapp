using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Rute
{
    public class RuteUrediVM
    {
        public int RutaID { get; set; }
        public string Naziv { get; set; }
        public string Pocetna { get; set; }
        public string Zavrsna { get; set; }
        public string Daljina { get; set; }
        public string CijenaPutarine { get; set; }
        public int KorisnikID { get; set; }
        public List<SelectListItem> korisnici { get; set; }
    }
}
