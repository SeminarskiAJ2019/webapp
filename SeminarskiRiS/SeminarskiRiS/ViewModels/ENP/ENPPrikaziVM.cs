using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.ENP
{
    public class ENPPrikaziVM
    {
        public int ENPID { get; set; }
        public string Naziv { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string RadnoVrijeme { get; set; }
        public string Grad { get; set; }
    }
}
