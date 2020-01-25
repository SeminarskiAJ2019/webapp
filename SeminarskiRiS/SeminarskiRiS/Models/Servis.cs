using SeminarskiRS1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Servis
    {
        [Key]
        public int ServisID { get; set; }
        public string LokacijaMap { get; set; }
        public string Opis { get; set; }
        public string RadnoVrijeme { get; set; }
        public string Usluge { get; set; }
        [ForeignKey("GradID")]
        public Grad Grad { get; set; }
        public int GradID { get; set; }
    }
}
