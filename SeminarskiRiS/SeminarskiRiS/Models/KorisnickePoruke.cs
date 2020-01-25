using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class KorisnickePoruke
    {
        [Key]
        public int KorisnickePorukeID { get; set; }
        public string Sadrzaj { get; set; }
        [ForeignKey("KorisnikID")]
        public Korisnik Korisnik { get; set; }
        public int KorisnikID { get; set; }
    }
}
