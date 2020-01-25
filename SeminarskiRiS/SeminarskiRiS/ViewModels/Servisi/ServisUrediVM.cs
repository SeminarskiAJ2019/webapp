using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Servisi
{
    public class ServisUrediVM
    {
        public int ServisID { get; set; }
        public string LokacijaMap { get; set; }
        public string Opis { get; set; }
        public string RadnoVrijeme { get; set; }
        public string Usluge { get; set; }
        public int GradID { get; set; }
        public List<SelectListItem> gradovi { get; set; }
    }
}
