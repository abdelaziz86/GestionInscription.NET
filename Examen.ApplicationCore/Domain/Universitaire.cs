using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Universitaire : Participant
    {
        public string niveau { get; set; }
        public string nomInstitut { get; set; }


        [ForeignKey("Specialite")]
        public int SpecialiteFK { get; set; }
        public virtual Specialite Specialite { get; set; }
    }
}
