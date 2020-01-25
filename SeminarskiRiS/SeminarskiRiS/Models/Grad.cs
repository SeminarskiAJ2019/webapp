using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class Grad
    {
        [Key]
        public int GradID { get; set; }
        public string Naziv { get; set; }
        [ForeignKey("KantonID")]
        public Kanton Kanton { get; set; }
        public int KantonID { get; set; }
    }
}
