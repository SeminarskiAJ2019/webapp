using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class KorisnickiNalog
    {
        [Key]
        public int KorisnickiNalogID { get; set; }
        public string KorisnickoIme { get; set; }
        public byte[] Lozinka { get; set; }
        public byte[] salt { get; set; }
    }
}
