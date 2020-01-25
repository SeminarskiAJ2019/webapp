using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Korisnik
    {
        [Key]
        public int KorisnikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string Adresa { get; set; }
        public string Spol { get; set; }
        [ForeignKey("GradID")]
        public Grad Grad { get; set; }
        public int GradID { get; set; }
        [ForeignKey("VoziloID")]
        public Vozilo Vozilo { get; set; }
        public int VoziloID { get; set; }
       
    }
}
