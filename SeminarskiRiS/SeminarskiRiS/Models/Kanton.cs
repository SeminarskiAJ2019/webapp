using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Kanton
    {
        [Key]
        public int KantonID { get; set; }
        public string NazivKantonta { get; set; }
        public string Skracenica { get; set; }
        [ForeignKey("DrzavaID")]
        public Drzava Drzava { get; set; }
        public int DrzavaID { get; set; }
    }
}
