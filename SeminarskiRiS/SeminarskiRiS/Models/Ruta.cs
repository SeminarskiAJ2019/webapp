using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Ruta
    {
        [Key]
        public int RutaID { get; set; }
        public string Naziv { get; set; }
        public string Pocetna { get; set; }
        public string Zavrsna { get; set; }
        public string Daljina { get; set; }
        public string CijenaPutarine { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
