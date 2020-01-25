using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Obavijesti
    {
        [Key]
        public int ObavijestID { get; set; }
        public string Datum { get; set; }
        public string Sadrzaj { get; set; }
        [ForeignKey("UposlenikID")]
        public Uposlenik Uposlenik { get; set; }
        public int UposlenikID { get; set; }
    }
}
