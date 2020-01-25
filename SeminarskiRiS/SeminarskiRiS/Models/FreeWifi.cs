using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class FreeWifi
    {
        [Key]
        public int WifiID { get; set; }
        public string LokacijaMap { get; set; }
        public string Opis { get; set; }
        public string PristupnaSifra { get; set; }
        [ForeignKey("GradID")]
        public Grad Grad { get; set; }
        public int GradID { get; set; }
    }
}
