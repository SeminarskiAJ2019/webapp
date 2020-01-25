using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Kantoni
{
    public class KantonUrediVM
    {
        public int KantonID { get; set; }
        public string NazivKantonta { get; set; }
        public string Skracenica { get; set; }
        public int DrzavaID { get; set; }
        public List<SelectListItem> drzave { get; set; }
    }
}
