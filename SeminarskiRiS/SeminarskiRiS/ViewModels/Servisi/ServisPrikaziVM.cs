using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Servisi
{
    public class ServisPrikaziVM
    {
        public int ServisID { get; set; }
        public string LokacijaMap { get; set; }
        public string Opis { get; set; }
        public string RadnoVrijeme { get; set; }
        public string Usluge { get; set; }
        public string Grad { get; set; }
    }
}
