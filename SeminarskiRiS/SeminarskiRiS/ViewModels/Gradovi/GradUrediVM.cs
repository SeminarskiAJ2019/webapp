using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.ViewModels
{
    public class GradUrediVM
    {
        public int GradID { get; set; }
        public string Naziv { get; set; }
        public int KantonID { get; set; }
        public List<SelectListItem> kantoni { get; set; }
    }
}
