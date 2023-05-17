using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Seminaire
    {
        [Key]
        public int code { get; set; }
        public string intitule { get; set; }
        public string lieu { get; set; }
        public double tarif { get; set; }
        public DateTime dateSeminaire { get; set; }
        [Range(0, 100)]
        public int nombreMaximal { get; set; }


        public virtual IList<Inscription> Inscriptions { get; set; }


    }
}
