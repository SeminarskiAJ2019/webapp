using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels
{
    public class VoziloUrediVM
    {
        public int VoziloID { get; set; }
        public string Tip { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int KS { get; set; }
        public string Potrosnja { get; set; }
        public string Registracija { get; set; }
        public DateTime VazenjeRegistracije { get; set; }
        public string Masa { get; set; }
        public string ZapreminaMotora { get; set; }
        public int GodinaProizvodnje { get; set; }
    }
}
