using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SeminarskiRS1.Models
{
    public class ENP
    {
        [Key]
        public int ENPID { get; set; }
        public string Naziv { get; set; }
        public string BrTelefona { get; set; }
        public string Email { get; set; }
        public string RadnoVrijeme { get; set; }
        [ForeignKey("GradID")]
        public Grad Grad { get; set; }
        public int GradID { get; set; }
    }
}
