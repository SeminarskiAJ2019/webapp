using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Uposlenici
{
    public class UposleniciUrediVM
    {
        public int UposlenikID { get; set;}
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string Spol { get; set; }
        public int UposlenikTipID { get; set; }
        public List<SelectListItem> tipovi { get; set; }
        public int GradID { get; set; }
        public List<SelectListItem> gradovi { get; set; }
    }
}
