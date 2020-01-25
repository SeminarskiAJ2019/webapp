using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Popust
    {
        [Key]
        public int PopustID { get; set; }
        public string Naziv { get; set; }
        public int KolicinaPopusta { get; set; }
    }
}
