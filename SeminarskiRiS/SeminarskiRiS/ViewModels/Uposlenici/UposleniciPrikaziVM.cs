using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Uposlenici
{
    public class UposleniciPrikaziVM
    {
        public int UposlenikID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }
        public string UposlenikTip { get; set; }
        public string Grad { get; set; }
    }
}
