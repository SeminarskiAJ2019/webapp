using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.EPunjaci
{
    public class EPunjacUrediVM
    {
        public int EPunjacID { get; set; }
        public string LokacijaMap { get; set; }
        public string LokacijaNaziv { get; set; }
        public string Opis { get; set; }
        public int GradID { get; set; }
        public List<SelectListItem> gradovi { get; set; }
    }
}
