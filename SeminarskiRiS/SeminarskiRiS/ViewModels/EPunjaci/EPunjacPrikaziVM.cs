using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.EPunjaci
{
    public class EPunjacPrikaziVM
    {
        public int EPunjacID { get; set; }
        public string LokacijaMap { get; set; }
        public string LokacijaNaziv { get; set; }
        public string Opis { get; set; }
        public string Grad { get; set; }
    }
}
