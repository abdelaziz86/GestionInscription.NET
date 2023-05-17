using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Participant
    {
        public int id { get; set; }
        [Required]
        [StringLength(50)]
        public string nom { get; set; }
        [Required]
        [StringLength(50)]
        public string prenom { get; set; }
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Adresse Mail")]
        public string email { get; set; }
        public int numeroTelephone { get; set; }

        
        public string Information { get { return nom + " " + prenom ; } }

        public virtual IList<Inscription> Inscriptions { get; set; }


    }
}
