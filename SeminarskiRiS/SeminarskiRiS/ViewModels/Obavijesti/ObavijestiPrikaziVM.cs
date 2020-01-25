using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Obavijesti
{
    public class ObavijestiPrikaziVM
    {
        public int ObavijestID { get; set; }
        public string Datum { get; set; }
        public string Sadrzaj { get; set; }
        public string Uposlenik { get; set; }
    }
}
