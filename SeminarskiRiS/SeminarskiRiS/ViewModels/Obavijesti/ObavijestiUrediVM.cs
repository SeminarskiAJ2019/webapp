using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels.Obavijesti
{
    public class ObavijestiUrediVM
    {
        public int ObavijestID { get; set; }
        public string Datum { get; set; }
        public string Sadrzaj { get; set; }
        public int UposlenikID { get; set; }
        public List<SelectListItem> uposlenici { get; set; }
    }
}
