using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Drzava
    {
        [Key]
        public int DrzavaID { get; set; }
        public string Naziv { get; set; }
    }
}
