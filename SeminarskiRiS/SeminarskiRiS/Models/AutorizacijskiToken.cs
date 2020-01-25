using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class AutorizacijskiToken
    {
        public int ID { get; set; }
        public string Vrijednost { get; set; }
        [ForeignKey(nameof(KorisnickiNalog))]
        public int KorisnickiNalogID { get; set; }
        public KorisnickiNalog KorisnickiNalog { get; set; }
        public DateTime VrijemeEvidentiranja { get; set; }
        public string IpAdresa { get; set; }
    }
}
